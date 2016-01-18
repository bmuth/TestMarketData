namespace TestMarketData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axTws = new AxTWSLib.AxTws();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rbTWS = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTicker = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStrike = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExpiry = new System.Windows.Forms.TextBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lbSecType = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSymbol = new System.Windows.Forms.Label();
            this.lbLocalsymbol = new System.Windows.Forms.Label();
            this.lbConid = new System.Windows.Forms.Label();
            this.lbRight = new System.Windows.Forms.Label();
            this.lbExpiry = new System.Windows.Forms.Label();
            this.lbExchange = new System.Windows.Forms.Label();
            this.tbExchange = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axTws)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axTws
            // 
            this.axTws.Enabled = true;
            this.axTws.Location = new System.Drawing.Point(222, 235);
            this.axTws.Name = "axTws";
            this.axTws.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTws.OcxState")));
            this.axTws.Size = new System.Drawing.Size(100, 50);
            this.axTws.TabIndex = 0;
            this.axTws.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(158, 49);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rbTWS
            // 
            this.rbTWS.AutoSize = true;
            this.rbTWS.Checked = true;
            this.rbTWS.Location = new System.Drawing.Point(16, 18);
            this.rbTWS.Name = "rbTWS";
            this.rbTWS.Size = new System.Drawing.Size(116, 17);
            this.rbTWS.TabIndex = 1;
            this.rbTWS.TabStop = true;
            this.rbTWS.Text = "Trader Workstation";
            this.rbTWS.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "IB Gateway";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(77, 64);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(20, 20);
            this.tbClientId.TabIndex = 3;
            this.tbClientId.Text = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client ID";
            // 
            // tbTicker
            // 
            this.tbTicker.Location = new System.Drawing.Point(69, 166);
            this.tbTicker.Name = "tbTicker";
            this.tbTicker.Size = new System.Drawing.Size(52, 20);
            this.tbTicker.TabIndex = 5;
            this.tbTicker.Leave += new System.EventHandler(this.tbTicker_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ticker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(55, 470);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 8;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbClientId);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbTWS);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 98);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Strike";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbStrike
            // 
            this.tbStrike.Location = new System.Drawing.Point(69, 195);
            this.tbStrike.Name = "tbStrike";
            this.tbStrike.Size = new System.Drawing.Size(52, 20);
            this.tbStrike.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Expiry";
            // 
            // tbExpiry
            // 
            this.tbExpiry.Location = new System.Drawing.Point(167, 195);
            this.tbExpiry.Name = "tbExpiry";
            this.tbExpiry.Size = new System.Drawing.Size(59, 20);
            this.tbExpiry.TabIndex = 7;
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(12, 270);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(348, 95);
            this.lbItems.TabIndex = 16;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // lbSecType
            // 
            this.lbSecType.FormattingEnabled = true;
            this.lbSecType.Items.AddRange(new object[] {
            "Stock",
            "Options",
            "Futures",
            "Future Options"});
            this.lbSecType.Location = new System.Drawing.Point(23, 111);
            this.lbSecType.Name = "lbSecType";
            this.lbSecType.Size = new System.Drawing.Size(120, 30);
            this.lbSecType.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(169, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "eg. ES or TF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "For TF use YYYMM, for ES use YYYMMDD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Localsymbol:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(4, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Conid:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Symbol:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(224, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Right:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(224, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Expiry:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(213, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Exchange:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSymbol
            // 
            this.lbSymbol.AutoSize = true;
            this.lbSymbol.Location = new System.Drawing.Point(78, 378);
            this.lbSymbol.Name = "lbSymbol";
            this.lbSymbol.Size = new System.Drawing.Size(16, 13);
            this.lbSymbol.TabIndex = 29;
            this.lbSymbol.Text = "   ";
            // 
            // lbLocalsymbol
            // 
            this.lbLocalsymbol.AutoSize = true;
            this.lbLocalsymbol.Location = new System.Drawing.Point(78, 400);
            this.lbLocalsymbol.Name = "lbLocalsymbol";
            this.lbLocalsymbol.Size = new System.Drawing.Size(16, 13);
            this.lbLocalsymbol.TabIndex = 30;
            this.lbLocalsymbol.Text = "   ";
            // 
            // lbConid
            // 
            this.lbConid.AutoSize = true;
            this.lbConid.Location = new System.Drawing.Point(78, 423);
            this.lbConid.Name = "lbConid";
            this.lbConid.Size = new System.Drawing.Size(16, 13);
            this.lbConid.TabIndex = 31;
            this.lbConid.Text = "   ";
            // 
            // lbRight
            // 
            this.lbRight.AutoSize = true;
            this.lbRight.Location = new System.Drawing.Point(284, 378);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(16, 13);
            this.lbRight.TabIndex = 32;
            this.lbRight.Text = "   ";
            // 
            // lbExpiry
            // 
            this.lbExpiry.AutoSize = true;
            this.lbExpiry.Location = new System.Drawing.Point(284, 400);
            this.lbExpiry.Name = "lbExpiry";
            this.lbExpiry.Size = new System.Drawing.Size(16, 13);
            this.lbExpiry.TabIndex = 33;
            this.lbExpiry.Text = "   ";
            // 
            // lbExchange
            // 
            this.lbExchange.AutoSize = true;
            this.lbExchange.Location = new System.Drawing.Point(284, 423);
            this.lbExchange.Name = "lbExchange";
            this.lbExchange.Size = new System.Drawing.Size(16, 13);
            this.lbExchange.TabIndex = 34;
            this.lbExchange.Text = "   ";
            // 
            // tbExchange
            // 
            this.tbExchange.Location = new System.Drawing.Point(296, 195);
            this.tbExchange.Name = "tbExchange";
            this.tbExchange.Size = new System.Drawing.Size(59, 20);
            this.tbExchange.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Exchange";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 505);
            this.Controls.Add(this.tbExchange);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbExchange);
            this.Controls.Add(this.lbExpiry);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbConid);
            this.Controls.Add(this.lbLocalsymbol);
            this.Controls.Add(this.lbSymbol);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbSecType);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbExpiry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStrike);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTicker);
            this.Controls.Add(this.axTws);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axTws)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxTWSLib.AxTws axTws;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RadioButton rbTWS;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStrike;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExpiry;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.ListBox lbSecType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSymbol;
        private System.Windows.Forms.Label lbLocalsymbol;
        private System.Windows.Forms.Label lbConid;
        private System.Windows.Forms.Label lbRight;
        private System.Windows.Forms.Label lbExpiry;
        private System.Windows.Forms.Label lbExchange;
        private System.Windows.Forms.TextBox tbExchange;
        private System.Windows.Forms.Label label13;
    }
}

