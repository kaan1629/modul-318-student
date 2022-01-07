// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace M318_Vebus
{
    using System.ComponentModel;
    using System.Linq;
    using SwissTransport.Core;
    using SwissTransport.Models;

    public partial class Form1 : Form
    {
        private readonly Formatierung format = new Formatierung();
        private readonly ITransport transport = new Transport();
        private readonly BindingList<string> suggestionsStart = new BindingList<string>();
        private readonly BindingList<string> suggestionsEnde = new BindingList<string>();
        private readonly BindingList<string> suggestionsStation = new BindingList<string>();
        private PanelResizing resizePanel = new PanelResizing();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            this.ListSuggestions.DataSource = this.suggestionsStart;
            this.ListSuggestionsEnde.DataSource = this.suggestionsEnde;
            this.ListSuggestionsStation.DataSource = this.suggestionsStation;
            this.TextStart.LostFocus += this.TextStart_LostFocus;
            this.TextEnde.LostFocus += this.TextEnde_LostFocus;
            this.TextStation.LostFocus += this.TextStation_LostFocus;
        }

        private void TextEnde_LostFocus(object? sender, EventArgs e)
        {
            this.ListSuggestionsEnde.Visible = false;
        }

        private void TextStation_LostFocus(object? sender, EventArgs e)
        {
            this.ListSuggestionsStation.Visible = false;
        }

        private void TextStart_LostFocus(object? sender, EventArgs e)
        {
            this.ListSuggestions.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void DataGridView_verbindung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Panel Navigation
        private void NavButtonVerbindungSuchen_Click(object sender, EventArgs e)
        {
            this.resizePanel.OpenClose(this.PanelVerbindung, this.PanelAbfahrtstafel, this.PanelKarte, this.PanelAdresse);
        }

        private void NavButtonKarte_Click(object sender, EventArgs e)
        {
            this.resizePanel.OpenClose(this.PanelAdresse, this.PanelAbfahrtstafel, this.PanelKarte, this.PanelVerbindung);
        }

        private void NavButtonAbfahrtstafel_Click(object sender, EventArgs e)
        {
            this.resizePanel.OpenClose(this.PanelAbfahrtstafel, this.PanelAdresse, this.PanelKarte, this.PanelVerbindung);
        }

        // Verbindung Suchen
        private void Button_Suchen_Click_1(object sender, EventArgs e)
        {
            // Records Idee von Mustafa Kara/ Michael Estermann
            try
            {
                string StartInput = this.TextStart.Text;
                string EndInput = this.TextEnde.Text;

                Connections Connection = this.transport.GetConnections(StartInput, EndInput);

                List<ConnectionRecord> values = Connection.ConnectionList
                    .Select(ConRecord => new ConnectionRecord(this.format.DatumEntfernen(ConRecord.From.Departure), this.format.DatumEntfernen(ConRecord.To.Arrival), this.format.ZeitEntfernen(ConRecord.Duration), this.format.VerspaetungCheck(ConRecord.To.Delay)))
                    .ToList();
                BindingList<ConnectionRecord>? List = new BindingList<ConnectionRecord>(values);
                this.DataGridViewVerbindung.DataSource = List;
                if(values == null || values.Count == 0)
                {
                    MessageBox.Show("Es wurden keine verbindungen gefunden. Bitte vesuchen Sie es nochmal.", "Error - Keine Verbindung");
                }
            }
            catch
            {
                MessageBox.Show("Ihre Eingabe ist Falsch. Es kann sein, dass Sie sich verschrieben haben, bitte stellen sie sicher, dass Ihre Eingabe richtig ist.", "Error - Falsche Eingabe");
            }
        }

        // Suchassistent

        // Suchfeld Start Verbindung
        private void TextStart_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextStart.Text))
            {
                return;
            }

            string stationQuery = this.TextStart.Text;

            Stations result = this.transport.GetStations(stationQuery);
            this.suggestionsStart.Clear();
            foreach (var station in result.StationList)
            {
                this.suggestionsStart.Add(station.Name);
            }

            this.ListSuggestions.Visible = true;
        }

        private void ListSuggestions_MouseClick(object sender, MouseEventArgs e)
        {
            for (var index = 0; index < this.ListSuggestions.Items.Count; index++)
            {
                if (this.ListSuggestions.GetItemRectangle(index).Contains(e.Location))
                {
                    this.TextStart.Text = this.ListSuggestions.Items[index].ToString();
                }
            }

            this.ListSuggestions.Visible = false;
        }

        private void TextStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && this.ListSuggestions.Visible && this.ListSuggestions.SelectedItem != null)
            {
                this.TextStart.Text = this.ListSuggestions.SelectedItem.ToString();
                this.TextStart.Select(this.TextStart.Text!.Length, 0);
            }
        }

        // Suchfeld Ende Verbindung
        private void TextEnde_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextEnde.Text))
            {
                return;
            }

            string stationQuery = this.TextEnde.Text;

            Stations result = this.transport.GetStations(stationQuery);
            this.suggestionsEnde.Clear();
            foreach (var station in result.StationList)
            {
                this.suggestionsEnde.Add(station.Name);
            }

            this.ListSuggestionsEnde.Visible = true;
        }

        private void ListSuggestionsEnd_MouseClick(object sender, MouseEventArgs e)
        {
            for (var index = 0; index < this.ListSuggestionsEnde.Items.Count; index++)
            {
                if (this.ListSuggestionsEnde.GetItemRectangle(index).Contains(e.Location))
                {
                    this.TextEnde.Text = this.ListSuggestionsEnde.Items[index].ToString();
                }
            }

            this.ListSuggestionsEnde.Visible = false;
        }

        private void TextEnde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && this.ListSuggestions.Visible && this.ListSuggestions.SelectedItem != null)
            {
                this.TextEnde.Text = this.ListSuggestionsEnde.SelectedItem.ToString();
                this.TextEnde.Select(this.TextEnde.Text!.Length, 0);
            }
        }

        // Suchfeld Station Abfahrtstafel
        private void TextStation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextStation.Text))
            {
                return;
            }

            string stationQuery = this.TextStation.Text;

            Stations result = this.transport.GetStations(stationQuery);
            this.suggestionsStation.Clear();
            foreach (var station in result.StationList)
            {
                this.suggestionsStation.Add(station.Name);
            }

            this.ListSuggestionsStation.Visible = true;
        }

        private void ListSuggestionsStation_MouseClick(object sender, MouseEventArgs e)
        {
            for (var index = 0; index < this.ListSuggestions.Items.Count; index++)
            {
                if (this.ListSuggestionsStation.GetItemRectangle(index).Contains(e.Location))
                {
                    this.TextStation.Text = this.ListSuggestionsStation.Items[index].ToString();
                }
            }

            this.ListSuggestions.Visible = false;
        }

        private void TextStation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && this.ListSuggestions.Visible && this.ListSuggestions.SelectedItem != null)
            {
                this.TextStation.Text = this.ListSuggestionsStation.SelectedItem.ToString();
                this.TextStation.Select(this.TextStation.Text!.Length, 0);
            }
        }

        // Abfahrtstafel
        private void ButtonAnzeigen_Click_1(object sender, EventArgs e)
        {
            try
            {
                string StationInput = this.TextStation.Text;

                Stations Station = this.transport
                    .GetStations(StationInput);

                var id = Station.StationList
                    .Select(Value => new IdRecord(Value.Id))
                    .ToString();

                StationBoardRoot StationBoardRoot = this.transport
                    .GetStationBoard(StationInput, id);

                var values = StationBoardRoot.Entries
                    .Select(x => new StationBoardRecord($"{x.Category}{x.Number}", x.To, this.format.DatumEntfernen(x.Stop.Departure), x.Operator))
                    .ToList();

                var bindingList = new BindingList<StationBoardRecord>(values);
                this.DataGridViewStationBoard.DataSource = bindingList;
            }
            catch
            {
                MessageBox.Show("Ihre Eîngabe ist Falsch. Es kann sein, dass Sie sich verschrieben haben, bitte stellen sie sicher, dass Ihre Eingabe richtig ist.", "Error - Falsche Eingabe");
            }
        }

        private record ConnectionRecord(string Abfahrt, string Ankunft, string Dauer, string Verspätung);

        private record IdRecord(string Id);

        private record StationBoardRecord(string Zug, string Nach, string Abfahrt, string Operator);
    }
}