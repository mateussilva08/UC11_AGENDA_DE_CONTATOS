namespace UC11_AGENDA_DE_CONTATOS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxTELEFONE = new System.Windows.Forms.TextBox();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxLINKEDIN = new System.Windows.Forms.TextBox();
            this.textBoxSOBRENOME = new System.Windows.Forms.TextBox();
            this.textBoxCELULAR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.buttonPESQUISAR = new System.Windows.Forms.Button();
            this.buttonEXCLUIR = new System.Windows.Forms.Button();
            this.buttonALTERAR = new System.Windows.Forms.Button();
            this.dataGridViewPESQUISA = new System.Windows.Forms.DataGridView();
            this.radioButtonDESBLOQUEADO = new System.Windows.Forms.RadioButton();
            this.radioButtonBLOQUEADO = new System.Windows.Forms.RadioButton();
            this.groupBoxATIVIDADE = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPESQUISA)).BeginInit();
            this.groupBoxATIVIDADE.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(50, 68);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(100, 20);
            this.textBoxNOME.TabIndex = 0;
            // 
            // textBoxTELEFONE
            // 
            this.textBoxTELEFONE.Location = new System.Drawing.Point(50, 137);
            this.textBoxTELEFONE.Name = "textBoxTELEFONE";
            this.textBoxTELEFONE.Size = new System.Drawing.Size(100, 20);
            this.textBoxTELEFONE.TabIndex = 1;
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(53, 199);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(100, 20);
            this.textBoxEMAIL.TabIndex = 2;
            // 
            // textBoxLINKEDIN
            // 
            this.textBoxLINKEDIN.Location = new System.Drawing.Point(219, 199);
            this.textBoxLINKEDIN.Name = "textBoxLINKEDIN";
            this.textBoxLINKEDIN.Size = new System.Drawing.Size(100, 20);
            this.textBoxLINKEDIN.TabIndex = 3;
            // 
            // textBoxSOBRENOME
            // 
            this.textBoxSOBRENOME.Location = new System.Drawing.Point(218, 68);
            this.textBoxSOBRENOME.Name = "textBoxSOBRENOME";
            this.textBoxSOBRENOME.Size = new System.Drawing.Size(100, 20);
            this.textBoxSOBRENOME.TabIndex = 5;
            // 
            // textBoxCELULAR
            // 
            this.textBoxCELULAR.Location = new System.Drawing.Point(219, 137);
            this.textBoxCELULAR.Name = "textBoxCELULAR";
            this.textBoxCELULAR.Size = new System.Drawing.Size(100, 20);
            this.textBoxCELULAR.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(50, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(215, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "LinkedIn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(215, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sobrenome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(215, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Celular";
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCADASTRAR.Location = new System.Drawing.Point(50, 375);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 13;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // buttonPESQUISAR
            // 
            this.buttonPESQUISAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPESQUISAR.Location = new System.Drawing.Point(559, 264);
            this.buttonPESQUISAR.Name = "buttonPESQUISAR";
            this.buttonPESQUISAR.Size = new System.Drawing.Size(369, 23);
            this.buttonPESQUISAR.TabIndex = 14;
            this.buttonPESQUISAR.Text = "Pesquisar";
            this.buttonPESQUISAR.UseVisualStyleBackColor = true;
            this.buttonPESQUISAR.Click += new System.EventHandler(this.buttonPESQUISAR_Click);
            // 
            // buttonEXCLUIR
            // 
            this.buttonEXCLUIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEXCLUIR.Location = new System.Drawing.Point(244, 375);
            this.buttonEXCLUIR.Name = "buttonEXCLUIR";
            this.buttonEXCLUIR.Size = new System.Drawing.Size(75, 23);
            this.buttonEXCLUIR.TabIndex = 15;
            this.buttonEXCLUIR.Text = "Excluir";
            this.buttonEXCLUIR.UseVisualStyleBackColor = true;
            this.buttonEXCLUIR.Click += new System.EventHandler(this.buttonEXCLUIR_Click);
            // 
            // buttonALTERAR
            // 
            this.buttonALTERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonALTERAR.Location = new System.Drawing.Point(149, 375);
            this.buttonALTERAR.Name = "buttonALTERAR";
            this.buttonALTERAR.Size = new System.Drawing.Size(75, 23);
            this.buttonALTERAR.TabIndex = 16;
            this.buttonALTERAR.Text = "Alterar";
            this.buttonALTERAR.UseVisualStyleBackColor = true;
            this.buttonALTERAR.Click += new System.EventHandler(this.buttonALTERAR_Click);
            // 
            // dataGridViewPESQUISA
            // 
            this.dataGridViewPESQUISA.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPESQUISA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPESQUISA.Location = new System.Drawing.Point(559, 29);
            this.dataGridViewPESQUISA.Name = "dataGridViewPESQUISA";
            this.dataGridViewPESQUISA.Size = new System.Drawing.Size(369, 222);
            this.dataGridViewPESQUISA.TabIndex = 17;
            this.dataGridViewPESQUISA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPESQUISA_CellContentClick);
            this.dataGridViewPESQUISA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPESQUISA_MouseClick);
            // 
            // radioButtonDESBLOQUEADO
            // 
            this.radioButtonDESBLOQUEADO.AutoSize = true;
            this.radioButtonDESBLOQUEADO.Location = new System.Drawing.Point(16, 39);
            this.radioButtonDESBLOQUEADO.Name = "radioButtonDESBLOQUEADO";
            this.radioButtonDESBLOQUEADO.Size = new System.Drawing.Size(94, 17);
            this.radioButtonDESBLOQUEADO.TabIndex = 18;
            this.radioButtonDESBLOQUEADO.TabStop = true;
            this.radioButtonDESBLOQUEADO.Text = "Desbloqueado";
            this.radioButtonDESBLOQUEADO.UseVisualStyleBackColor = true;
            this.radioButtonDESBLOQUEADO.CheckedChanged += new System.EventHandler(this.radioButtonDESBLOQUEADO_CheckedChanged);
            // 
            // radioButtonBLOQUEADO
            // 
            this.radioButtonBLOQUEADO.AutoSize = true;
            this.radioButtonBLOQUEADO.Location = new System.Drawing.Point(169, 39);
            this.radioButtonBLOQUEADO.Name = "radioButtonBLOQUEADO";
            this.radioButtonBLOQUEADO.Size = new System.Drawing.Size(76, 17);
            this.radioButtonBLOQUEADO.TabIndex = 19;
            this.radioButtonBLOQUEADO.TabStop = true;
            this.radioButtonBLOQUEADO.Text = "Bloqueado";
            this.radioButtonBLOQUEADO.UseVisualStyleBackColor = true;
            // 
            // groupBoxATIVIDADE
            // 
            this.groupBoxATIVIDADE.Controls.Add(this.radioButtonDESBLOQUEADO);
            this.groupBoxATIVIDADE.Controls.Add(this.radioButtonBLOQUEADO);
            this.groupBoxATIVIDADE.Location = new System.Drawing.Point(53, 247);
            this.groupBoxATIVIDADE.Name = "groupBoxATIVIDADE";
            this.groupBoxATIVIDADE.Size = new System.Drawing.Size(271, 100);
            this.groupBoxATIVIDADE.TabIndex = 20;
            this.groupBoxATIVIDADE.TabStop = false;
            this.groupBoxATIVIDADE.Text = "Situação";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(364, 68);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 21;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(361, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "id";
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLIMPAR.Location = new System.Drawing.Point(149, 429);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(75, 23);
            this.buttonLIMPAR.TabIndex = 23;
            this.buttonLIMPAR.Text = "Limpar";
            this.buttonLIMPAR.UseVisualStyleBackColor = true;
            this.buttonLIMPAR.Click += new System.EventHandler(this.buttonLIMPAR_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.groupBoxATIVIDADE);
            this.Controls.Add(this.dataGridViewPESQUISA);
            this.Controls.Add(this.buttonALTERAR);
            this.Controls.Add(this.buttonEXCLUIR);
            this.Controls.Add(this.buttonPESQUISAR);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCELULAR);
            this.Controls.Add(this.textBoxSOBRENOME);
            this.Controls.Add(this.textBoxLINKEDIN);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.textBoxTELEFONE);
            this.Controls.Add(this.textBoxNOME);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPESQUISA)).EndInit();
            this.groupBoxATIVIDADE.ResumeLayout(false);
            this.groupBoxATIVIDADE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxTELEFONE;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxLINKEDIN;
        private System.Windows.Forms.TextBox textBoxSOBRENOME;
        private System.Windows.Forms.TextBox textBoxCELULAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Button buttonPESQUISAR;
        private System.Windows.Forms.Button buttonEXCLUIR;
        private System.Windows.Forms.Button buttonALTERAR;
        private System.Windows.Forms.DataGridView dataGridViewPESQUISA;
        private System.Windows.Forms.RadioButton radioButtonDESBLOQUEADO;
        private System.Windows.Forms.RadioButton radioButtonBLOQUEADO;
        private System.Windows.Forms.GroupBox groupBoxATIVIDADE;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonLIMPAR;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}

