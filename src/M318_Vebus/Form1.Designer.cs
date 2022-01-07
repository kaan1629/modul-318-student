namespace M318_Vebus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NavButtonAbfahrtstafel = new System.Windows.Forms.Button();
            this.NavButtonVerbindungSuchen = new System.Windows.Forms.Button();
            this.NavButtonKarte = new System.Windows.Forms.Button();
            this.PanelVerbindung = new System.Windows.Forms.Panel();
            this.ListSuggestionsEnde = new System.Windows.Forms.ListBox();
            this.ListSuggestions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextEnde = new System.Windows.Forms.TextBox();
            this.TextStart = new System.Windows.Forms.TextBox();
            this.DataGridViewVerbindung = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_datum = new System.Windows.Forms.DateTimePicker();
            this.Button_Karte = new System.Windows.Forms.Button();
            this.Button_EMailBenachrichtigung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_suche_uhrzeit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Suchen = new System.Windows.Forms.Button();
            this.label_suchfeld_start = new System.Windows.Forms.Label();
            this.PanelAbfahrtstafel = new System.Windows.Forms.Panel();
            this.ListSuggestionsStation = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextStation = new System.Windows.Forms.TextBox();
            this.DataGridViewStationBoard = new System.Windows.Forms.DataGridView();
            this.ButtonAnzeigen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelKarte = new System.Windows.Forms.Panel();
            this.PanelAdresse = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelVerbindung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVerbindung)).BeginInit();
            this.PanelAbfahrtstafel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStationBoard)).BeginInit();
            this.PanelAdresse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.NavButtonAbfahrtstafel);
            this.panel1.Controls.Add(this.NavButtonVerbindungSuchen);
            this.panel1.Controls.Add(this.NavButtonKarte);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 66);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 406);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 65);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // NavButtonAbfahrtstafel
            // 
            this.NavButtonAbfahrtstafel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavButtonAbfahrtstafel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavButtonAbfahrtstafel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NavButtonAbfahrtstafel.Location = new System.Drawing.Point(760, 0);
            this.NavButtonAbfahrtstafel.Name = "NavButtonAbfahrtstafel";
            this.NavButtonAbfahrtstafel.Size = new System.Drawing.Size(297, 65);
            this.NavButtonAbfahrtstafel.TabIndex = 16;
            this.NavButtonAbfahrtstafel.Text = "Abfahrtstafel";
            this.NavButtonAbfahrtstafel.UseVisualStyleBackColor = true;
            this.NavButtonAbfahrtstafel.Click += new System.EventHandler(this.NavButtonAbfahrtstafel_Click);
            // 
            // NavButtonVerbindungSuchen
            // 
            this.NavButtonVerbindungSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavButtonVerbindungSuchen.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavButtonVerbindungSuchen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NavButtonVerbindungSuchen.Location = new System.Drawing.Point(206, 0);
            this.NavButtonVerbindungSuchen.Name = "NavButtonVerbindungSuchen";
            this.NavButtonVerbindungSuchen.Size = new System.Drawing.Size(263, 65);
            this.NavButtonVerbindungSuchen.TabIndex = 14;
            this.NavButtonVerbindungSuchen.Text = "Verbindung Suchen";
            this.NavButtonVerbindungSuchen.UseVisualStyleBackColor = true;
            this.NavButtonVerbindungSuchen.Click += new System.EventHandler(this.NavButtonVerbindungSuchen_Click);
            // 
            // NavButtonKarte
            // 
            this.NavButtonKarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavButtonKarte.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavButtonKarte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NavButtonKarte.Location = new System.Drawing.Point(464, 0);
            this.NavButtonKarte.Name = "NavButtonKarte";
            this.NavButtonKarte.Size = new System.Drawing.Size(299, 65);
            this.NavButtonKarte.TabIndex = 15;
            this.NavButtonKarte.Text = "Adresse";
            this.NavButtonKarte.UseVisualStyleBackColor = true;
            this.NavButtonKarte.Click += new System.EventHandler(this.NavButtonKarte_Click);
            // 
            // PanelVerbindung
            // 
            this.PanelVerbindung.Controls.Add(this.ListSuggestionsEnde);
            this.PanelVerbindung.Controls.Add(this.ListSuggestions);
            this.PanelVerbindung.Controls.Add(this.label2);
            this.PanelVerbindung.Controls.Add(this.TextEnde);
            this.PanelVerbindung.Controls.Add(this.TextStart);
            this.PanelVerbindung.Controls.Add(this.DataGridViewVerbindung);
            this.PanelVerbindung.Controls.Add(this.dateTimePicker_datum);
            this.PanelVerbindung.Controls.Add(this.Button_Karte);
            this.PanelVerbindung.Controls.Add(this.Button_EMailBenachrichtigung);
            this.PanelVerbindung.Controls.Add(this.label4);
            this.PanelVerbindung.Controls.Add(this.textBox_suche_uhrzeit);
            this.PanelVerbindung.Controls.Add(this.label3);
            this.PanelVerbindung.Controls.Add(this.Button_Suchen);
            this.PanelVerbindung.Controls.Add(this.label_suchfeld_start);
            this.PanelVerbindung.Location = new System.Drawing.Point(4, 72);
            this.PanelVerbindung.Name = "PanelVerbindung";
            this.PanelVerbindung.Size = new System.Drawing.Size(945, 545);
            this.PanelVerbindung.TabIndex = 18;
            // 
            // ListSuggestionsEnde
            // 
            this.ListSuggestionsEnde.FormattingEnabled = true;
            this.ListSuggestionsEnde.ItemHeight = 20;
            this.ListSuggestionsEnde.Location = new System.Drawing.Point(589, 105);
            this.ListSuggestionsEnde.Name = "ListSuggestionsEnde";
            this.ListSuggestionsEnde.Size = new System.Drawing.Size(151, 104);
            this.ListSuggestionsEnde.TabIndex = 32;
            this.ListSuggestionsEnde.Visible = false;
            this.ListSuggestionsEnde.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListSuggestionsEnd_MouseClick);
            // 
            // ListSuggestions
            // 
            this.ListSuggestions.FormattingEnabled = true;
            this.ListSuggestions.ItemHeight = 20;
            this.ListSuggestions.Location = new System.Drawing.Point(283, 105);
            this.ListSuggestions.Name = "ListSuggestions";
            this.ListSuggestions.Size = new System.Drawing.Size(151, 104);
            this.ListSuggestions.TabIndex = 31;
            this.ListSuggestions.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "Verbindung Suchen";
            // 
            // TextEnde
            // 
            this.TextEnde.Location = new System.Drawing.Point(589, 82);
            this.TextEnde.Name = "TextEnde";
            this.TextEnde.Size = new System.Drawing.Size(151, 27);
            this.TextEnde.TabIndex = 2;
            this.TextEnde.TextChanged += new System.EventHandler(this.TextEnde_TextChanged);
            this.TextEnde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextEnde_KeyPress);
            // 
            // TextStart
            // 
            this.TextStart.Location = new System.Drawing.Point(283, 82);
            this.TextStart.Name = "TextStart";
            this.TextStart.Size = new System.Drawing.Size(151, 27);
            this.TextStart.TabIndex = 1;
            this.TextStart.TextChanged += new System.EventHandler(this.TextStart_TextChanged);
            // 
            // DataGridViewVerbindung
            // 
            this.DataGridViewVerbindung.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewVerbindung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVerbindung.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridViewVerbindung.Location = new System.Drawing.Point(187, 271);
            this.DataGridViewVerbindung.Name = "DataGridViewVerbindung";
            this.DataGridViewVerbindung.RowHeadersWidth = 51;
            this.DataGridViewVerbindung.RowTemplate.Height = 29;
            this.DataGridViewVerbindung.Size = new System.Drawing.Size(553, 188);
            this.DataGridViewVerbindung.TabIndex = 19;
            // 
            // dateTimePicker_datum
            // 
            this.dateTimePicker_datum.Location = new System.Drawing.Point(187, 166);
            this.dateTimePicker_datum.Name = "dateTimePicker_datum";
            this.dateTimePicker_datum.Size = new System.Drawing.Size(247, 27);
            this.dateTimePicker_datum.TabIndex = 26;
            this.dateTimePicker_datum.TabStop = false;
            // 
            // Button_Karte
            // 
            this.Button_Karte.Location = new System.Drawing.Point(646, 479);
            this.Button_Karte.Name = "Button_Karte";
            this.Button_Karte.Size = new System.Drawing.Size(94, 29);
            this.Button_Karte.TabIndex = 25;
            this.Button_Karte.Text = "Karte";
            this.Button_Karte.UseVisualStyleBackColor = true;
            // 
            // Button_EMailBenachrichtigung
            // 
            this.Button_EMailBenachrichtigung.Location = new System.Drawing.Point(187, 479);
            this.Button_EMailBenachrichtigung.Name = "Button_EMailBenachrichtigung";
            this.Button_EMailBenachrichtigung.Size = new System.Drawing.Size(202, 29);
            this.Button_EMailBenachrichtigung.TabIndex = 24;
            this.Button_EMailBenachrichtigung.Text = "E-Mail-Benachrichtigung";
            this.Button_EMailBenachrichtigung.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(496, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ende";
            // 
            // textBox_suche_uhrzeit
            // 
            this.textBox_suche_uhrzeit.Location = new System.Drawing.Point(283, 199);
            this.textBox_suche_uhrzeit.Name = "textBox_suche_uhrzeit";
            this.textBox_suche_uhrzeit.Size = new System.Drawing.Size(151, 27);
            this.textBox_suche_uhrzeit.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(187, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Uhrzeit";
            // 
            // Button_Suchen
            // 
            this.Button_Suchen.Location = new System.Drawing.Point(646, 199);
            this.Button_Suchen.Name = "Button_Suchen";
            this.Button_Suchen.Size = new System.Drawing.Size(94, 29);
            this.Button_Suchen.TabIndex = 3;
            this.Button_Suchen.Text = "Suchen";
            this.Button_Suchen.UseVisualStyleBackColor = true;
            this.Button_Suchen.Click += new System.EventHandler(this.Button_Suchen_Click_1);
            // 
            // label_suchfeld_start
            // 
            this.label_suchfeld_start.AutoSize = true;
            this.label_suchfeld_start.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_suchfeld_start.Location = new System.Drawing.Point(187, 84);
            this.label_suchfeld_start.Name = "label_suchfeld_start";
            this.label_suchfeld_start.Size = new System.Drawing.Size(56, 25);
            this.label_suchfeld_start.TabIndex = 18;
            this.label_suchfeld_start.Text = "Start";
            // 
            // PanelAbfahrtstafel
            // 
            this.PanelAbfahrtstafel.Controls.Add(this.ListSuggestionsStation);
            this.PanelAbfahrtstafel.Controls.Add(this.label6);
            this.PanelAbfahrtstafel.Controls.Add(this.TextStation);
            this.PanelAbfahrtstafel.Controls.Add(this.DataGridViewStationBoard);
            this.PanelAbfahrtstafel.Controls.Add(this.ButtonAnzeigen);
            this.PanelAbfahrtstafel.Controls.Add(this.label1);
            this.PanelAbfahrtstafel.Location = new System.Drawing.Point(985, 487);
            this.PanelAbfahrtstafel.Name = "PanelAbfahrtstafel";
            this.PanelAbfahrtstafel.Size = new System.Drawing.Size(56, 35);
            this.PanelAbfahrtstafel.TabIndex = 19;
            // 
            // ListSuggestionsStation
            // 
            this.ListSuggestionsStation.FormattingEnabled = true;
            this.ListSuggestionsStation.ItemHeight = 20;
            this.ListSuggestionsStation.Location = new System.Drawing.Point(293, 138);
            this.ListSuggestionsStation.Name = "ListSuggestionsStation";
            this.ListSuggestionsStation.Size = new System.Drawing.Size(125, 104);
            this.ListSuggestionsStation.TabIndex = 31;
            this.ListSuggestionsStation.Visible = false;
            this.ListSuggestionsStation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListSuggestionsStation_MouseClick);
            this.ListSuggestionsStation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStation_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(76, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 37);
            this.label6.TabIndex = 30;
            this.label6.Text = "Abfahrtstafel";
            // 
            // TextStation
            // 
            this.TextStation.Location = new System.Drawing.Point(293, 107);
            this.TextStation.Name = "TextStation";
            this.TextStation.Size = new System.Drawing.Size(125, 27);
            this.TextStation.TabIndex = 29;
            this.TextStation.TextChanged += new System.EventHandler(this.TextStation_TextChanged);
            // 
            // DataGridViewStationBoard
            // 
            this.DataGridViewStationBoard.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStationBoard.Location = new System.Drawing.Point(184, 191);
            this.DataGridViewStationBoard.Name = "DataGridViewStationBoard";
            this.DataGridViewStationBoard.RowHeadersWidth = 51;
            this.DataGridViewStationBoard.RowTemplate.Height = 29;
            this.DataGridViewStationBoard.Size = new System.Drawing.Size(553, 311);
            this.DataGridViewStationBoard.TabIndex = 28;
            // 
            // ButtonAnzeigen
            // 
            this.ButtonAnzeigen.Location = new System.Drawing.Point(643, 105);
            this.ButtonAnzeigen.Name = "ButtonAnzeigen";
            this.ButtonAnzeigen.Size = new System.Drawing.Size(94, 29);
            this.ButtonAnzeigen.TabIndex = 27;
            this.ButtonAnzeigen.Text = "Anzeigen";
            this.ButtonAnzeigen.UseVisualStyleBackColor = true;
            this.ButtonAnzeigen.Click += new System.EventHandler(this.ButtonAnzeigen_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Station";
            // 
            // PanelKarte
            // 
            this.PanelKarte.Location = new System.Drawing.Point(985, 431);
            this.PanelKarte.Name = "PanelKarte";
            this.PanelKarte.Size = new System.Drawing.Size(56, 36);
            this.PanelKarte.TabIndex = 30;
            // 
            // PanelAdresse
            // 
            this.PanelAdresse.Controls.Add(this.label5);
            this.PanelAdresse.Location = new System.Drawing.Point(985, 378);
            this.PanelAdresse.Name = "PanelAdresse";
            this.PanelAdresse.Size = new System.Drawing.Size(56, 37);
            this.PanelAdresse.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 617);
            this.Controls.Add(this.PanelAbfahrtstafel);
            this.Controls.Add(this.PanelAdresse);
            this.Controls.Add(this.PanelKarte);
            this.Controls.Add(this.PanelVerbindung);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Suchen - Vebus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelVerbindung.ResumeLayout(false);
            this.PanelVerbindung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVerbindung)).EndInit();
            this.PanelAbfahrtstafel.ResumeLayout(false);
            this.PanelAbfahrtstafel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStationBoard)).EndInit();
            this.PanelAdresse.ResumeLayout(false);
            this.PanelAdresse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button NavButtonAbfahrtstafel;
        private Button NavButtonKarte;
        private Button NavButtonVerbindungSuchen;
        private PictureBox pictureBox1;
        private Panel PanelVerbindung;
        private TextBox TextEnde;
        private TextBox TextStart;
        private DataGridView DataGridViewVerbindung;
        private DateTimePicker dateTimePicker_datum;
        private Button Button_Karte;
        private Button Button_EMailBenachrichtigung;
        private Label label4;
        private TextBox textBox_suche_uhrzeit;
        private Label label3;
        private Button Button_Suchen;
        private Label label_suchfeld_start;
        private Panel panel2;
        private Panel PanelAbfahrtstafel;
        private TextBox TextStation;
        private DataGridView DataGridViewStationBoard;
        private Button ButtonAnzeigen;
        private Label label1;
        private Panel PanelKarte;
        private Panel PanelAdresse;
        private Label label2;
        private Label label5;
        private Label label6;
        private ListBox ListSuggestions;
        private ListBox ListSuggestionsEnde;
        private ListBox ListSuggestionsStation;
    }
}