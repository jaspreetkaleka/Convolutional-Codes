namespace Convolutional_Codes
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.inputTabPage = new System.Windows.Forms.TabPage();
            this.gXDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gXColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_CL_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.k_TextBox = new System.Windows.Forms.TextBox();
            this.n_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codewordsTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.U_TextBox = new System.Windows.Forms.RichTextBox();
            this.errorDetectionTabPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.S_ED_Label = new System.Windows.Forms.Label();
            this.S_ED_TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rol_ED_Button = new System.Windows.Forms.Button();
            this.ror_ED_Button = new System.Windows.Forms.Button();
            this.detectErrorButton = new System.Windows.Forms.Button();
            this.r_ED_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorCorrectionTabPage = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.U_EC_TextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.correctErrorButton = new System.Windows.Forms.Button();
            this.r_EC_TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.S_EC_TextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mainErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainTabControl.SuspendLayout();
            this.inputTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gXDataGridView)).BeginInit();
            this.codewordsTabPage.SuspendLayout();
            this.errorDetectionTabPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.errorCorrectionTabPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.inputTabPage);
            this.mainTabControl.Controls.Add(this.codewordsTabPage);
            this.mainTabControl.Controls.Add(this.errorDetectionTabPage);
            this.mainTabControl.Controls.Add(this.errorCorrectionTabPage);
            this.mainTabControl.Controls.Add(this.aboutTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(734, 464);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTabControl_Selecting);
            // 
            // inputTabPage
            // 
            this.inputTabPage.BackColor = System.Drawing.Color.White;
            this.inputTabPage.BackgroundImage = global::ConvolutionalCodes.Properties.Resources.Wooden_Background;
            this.inputTabPage.Controls.Add(this.gXDataGridView);
            this.inputTabPage.Controls.Add(this.K_CL_TextBox);
            this.inputTabPage.Controls.Add(this.label5);
            this.inputTabPage.Controls.Add(this.label3);
            this.inputTabPage.Controls.Add(this.k_TextBox);
            this.inputTabPage.Controls.Add(this.n_TextBox);
            this.inputTabPage.Controls.Add(this.label1);
            this.inputTabPage.Controls.Add(this.label2);
            this.inputTabPage.Location = new System.Drawing.Point(4, 27);
            this.inputTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTabPage.Name = "inputTabPage";
            this.inputTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTabPage.Size = new System.Drawing.Size(726, 433);
            this.inputTabPage.TabIndex = 0;
            this.inputTabPage.Text = "Inputs < n, k, g(X) > ";
            // 
            // gXDataGridView
            // 
            this.gXDataGridView.AllowUserToAddRows = false;
            this.gXDataGridView.AllowUserToDeleteRows = false;
            this.gXDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gXDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gXDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gXDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.gXColumn});
            this.gXDataGridView.Location = new System.Drawing.Point(353, 178);
            this.gXDataGridView.Name = "gXDataGridView";
            this.gXDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gXDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gXDataGridView.RowTemplate.Height = 30;
            this.gXDataGridView.Size = new System.Drawing.Size(322, 243);
            this.gXDataGridView.TabIndex = 12;
            this.gXDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gXDataGridView_CellEndEdit);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // gXColumn
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.gXColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.gXColumn.HeaderText = "g(X)";
            this.gXColumn.Name = "gXColumn";
            this.gXColumn.Width = 150;
            // 
            // K_CL_TextBox
            // 
            this.K_CL_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.K_CL_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.K_CL_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K_CL_TextBox.ForeColor = System.Drawing.Color.Black;
            this.K_CL_TextBox.HideSelection = false;
            this.K_CL_TextBox.Location = new System.Drawing.Point(353, 117);
            this.K_CL_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.K_CL_TextBox.Name = "K_CL_TextBox";
            this.K_CL_TextBox.Size = new System.Drawing.Size(322, 37);
            this.K_CL_TextBox.TabIndex = 2;
            this.K_CL_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.K_CL_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.knK_TextBox_KeyDown);
            this.K_CL_TextBox.Leave += new System.EventHandler(this.K_CL_TextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(111, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Constraint Length, K = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Generator Polynomial, g(X) = ";
            // 
            // k_TextBox
            // 
            this.k_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.k_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.k_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_TextBox.ForeColor = System.Drawing.Color.Black;
            this.k_TextBox.HideSelection = false;
            this.k_TextBox.Location = new System.Drawing.Point(353, 11);
            this.k_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.k_TextBox.Name = "k_TextBox";
            this.k_TextBox.Size = new System.Drawing.Size(322, 37);
            this.k_TextBox.TabIndex = 0;
            this.k_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.k_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.knK_TextBox_KeyDown);
            this.k_TextBox.Leave += new System.EventHandler(this.k_TextBox_Leave);
            // 
            // n_TextBox
            // 
            this.n_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.n_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_TextBox.ForeColor = System.Drawing.Color.Black;
            this.n_TextBox.HideSelection = false;
            this.n_TextBox.Location = new System.Drawing.Point(353, 63);
            this.n_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n_TextBox.Name = "n_TextBox";
            this.n_TextBox.Size = new System.Drawing.Size(322, 37);
            this.n_TextBox.TabIndex = 1;
            this.n_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.n_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.knK_TextBox_KeyDown);
            this.n_TextBox.Leave += new System.EventHandler(this.n_TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(159, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message Bits, k = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(182, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Coded Bits, n = ";
            // 
            // codewordsTabPage
            // 
            this.codewordsTabPage.BackColor = System.Drawing.Color.White;
            this.codewordsTabPage.Controls.Add(this.label4);
            this.codewordsTabPage.Controls.Add(this.label8);
            this.codewordsTabPage.Controls.Add(this.label7);
            this.codewordsTabPage.Controls.Add(this.U_TextBox);
            this.codewordsTabPage.Location = new System.Drawing.Point(4, 27);
            this.codewordsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codewordsTabPage.Name = "codewordsTabPage";
            this.codewordsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codewordsTabPage.Size = new System.Drawing.Size(726, 433);
            this.codewordsTabPage.TabIndex = 2;
            this.codewordsTabPage.Text = "Codewords <U>";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(325, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "- - - - -";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(558, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Codeword <U(X)>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(8, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Message <m(X)>";
            // 
            // U_TextBox
            // 
            this.U_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.U_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.U_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.U_TextBox.DetectUrls = false;
            this.U_TextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_TextBox.ForeColor = System.Drawing.Color.Black;
            this.U_TextBox.HideSelection = false;
            this.U_TextBox.Location = new System.Drawing.Point(8, 32);
            this.U_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.U_TextBox.Name = "U_TextBox";
            this.U_TextBox.ReadOnly = true;
            this.U_TextBox.Size = new System.Drawing.Size(710, 394);
            this.U_TextBox.TabIndex = 0;
            this.U_TextBox.Text = "";
            this.U_TextBox.WordWrap = false;
            this.U_TextBox.ZoomFactor = 1.5F;
            // 
            // errorDetectionTabPage
            // 
            this.errorDetectionTabPage.BackColor = System.Drawing.Color.White;
            this.errorDetectionTabPage.Controls.Add(this.groupBox4);
            this.errorDetectionTabPage.Controls.Add(this.groupBox3);
            this.errorDetectionTabPage.Location = new System.Drawing.Point(4, 27);
            this.errorDetectionTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorDetectionTabPage.Name = "errorDetectionTabPage";
            this.errorDetectionTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorDetectionTabPage.Size = new System.Drawing.Size(726, 433);
            this.errorDetectionTabPage.TabIndex = 3;
            this.errorDetectionTabPage.Text = "Error Detection";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.S_ED_Label);
            this.groupBox4.Controls.Add(this.S_ED_TextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 185);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(720, 171);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Syndrome Polynomial S(X)";
            // 
            // S_ED_Label
            // 
            this.S_ED_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.S_ED_Label.AutoSize = true;
            this.S_ED_Label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_ED_Label.ForeColor = System.Drawing.Color.Green;
            this.S_ED_Label.Location = new System.Drawing.Point(101, 96);
            this.S_ED_Label.Name = "S_ED_Label";
            this.S_ED_Label.Size = new System.Drawing.Size(0, 29);
            this.S_ED_Label.TabIndex = 8;
            // 
            // S_ED_TextBox
            // 
            this.S_ED_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.S_ED_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.S_ED_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.S_ED_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_ED_TextBox.ForeColor = System.Drawing.Color.Black;
            this.S_ED_TextBox.Location = new System.Drawing.Point(101, 46);
            this.S_ED_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.S_ED_TextBox.Name = "S_ED_TextBox";
            this.S_ED_TextBox.ReadOnly = true;
            this.S_ED_TextBox.Size = new System.Drawing.Size(585, 37);
            this.S_ED_TextBox.TabIndex = 0;
            this.S_ED_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "S(X) = ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rol_ED_Button);
            this.groupBox3.Controls.Add(this.ror_ED_Button);
            this.groupBox3.Controls.Add(this.detectErrorButton);
            this.groupBox3.Controls.Add(this.r_ED_TextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(720, 171);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Received Polynomial Z(X)";
            // 
            // rol_ED_Button
            // 
            this.rol_ED_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rol_ED_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rol_ED_Button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol_ED_Button.Location = new System.Drawing.Point(165, 94);
            this.rol_ED_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rol_ED_Button.Name = "rol_ED_Button";
            this.rol_ED_Button.Size = new System.Drawing.Size(148, 32);
            this.rol_ED_Button.TabIndex = 4;
            this.rol_ED_Button.Text = "Rotate Left";
            this.rol_ED_Button.UseVisualStyleBackColor = true;
            // 
            // ror_ED_Button
            // 
            this.ror_ED_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ror_ED_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ror_ED_Button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ror_ED_Button.Location = new System.Drawing.Point(473, 94);
            this.ror_ED_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ror_ED_Button.Name = "ror_ED_Button";
            this.ror_ED_Button.Size = new System.Drawing.Size(148, 32);
            this.ror_ED_Button.TabIndex = 3;
            this.ror_ED_Button.Text = "Rotate Right";
            this.ror_ED_Button.UseVisualStyleBackColor = true;
            // 
            // detectErrorButton
            // 
            this.detectErrorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detectErrorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detectErrorButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectErrorButton.Location = new System.Drawing.Point(319, 94);
            this.detectErrorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detectErrorButton.Name = "detectErrorButton";
            this.detectErrorButton.Size = new System.Drawing.Size(148, 32);
            this.detectErrorButton.TabIndex = 2;
            this.detectErrorButton.Text = "Detect Error";
            this.detectErrorButton.UseVisualStyleBackColor = true;
            // 
            // r_ED_TextBox
            // 
            this.r_ED_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.r_ED_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r_ED_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.r_ED_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_ED_TextBox.ForeColor = System.Drawing.Color.Black;
            this.r_ED_TextBox.Location = new System.Drawing.Point(101, 44);
            this.r_ED_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.r_ED_TextBox.Name = "r_ED_TextBox";
            this.r_ED_TextBox.Size = new System.Drawing.Size(585, 37);
            this.r_ED_TextBox.TabIndex = 0;
            this.r_ED_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Z(X) = ";
            // 
            // errorCorrectionTabPage
            // 
            this.errorCorrectionTabPage.BackColor = System.Drawing.Color.White;
            this.errorCorrectionTabPage.Controls.Add(this.groupBox7);
            this.errorCorrectionTabPage.Controls.Add(this.groupBox5);
            this.errorCorrectionTabPage.Controls.Add(this.groupBox6);
            this.errorCorrectionTabPage.Location = new System.Drawing.Point(4, 27);
            this.errorCorrectionTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorCorrectionTabPage.Name = "errorCorrectionTabPage";
            this.errorCorrectionTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorCorrectionTabPage.Size = new System.Drawing.Size(726, 433);
            this.errorCorrectionTabPage.TabIndex = 4;
            this.errorCorrectionTabPage.Text = "Error Correction";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.U_EC_TextBox);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(8, 297);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(720, 135);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Estimated Polynomial U(X)";
            // 
            // U_EC_TextBox
            // 
            this.U_EC_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.U_EC_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.U_EC_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.U_EC_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_EC_TextBox.ForeColor = System.Drawing.Color.Black;
            this.U_EC_TextBox.Location = new System.Drawing.Point(102, 49);
            this.U_EC_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.U_EC_TextBox.Name = "U_EC_TextBox";
            this.U_EC_TextBox.ReadOnly = true;
            this.U_EC_TextBox.Size = new System.Drawing.Size(594, 37);
            this.U_EC_TextBox.TabIndex = 0;
            this.U_EC_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "U(X) = ";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.correctErrorButton);
            this.groupBox5.Controls.Add(this.r_EC_TextBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 11);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(720, 135);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Received Polynomial Z(X)";
            // 
            // correctErrorButton
            // 
            this.correctErrorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.correctErrorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.correctErrorButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctErrorButton.Location = new System.Drawing.Point(303, 83);
            this.correctErrorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.correctErrorButton.Name = "correctErrorButton";
            this.correctErrorButton.Size = new System.Drawing.Size(194, 32);
            this.correctErrorButton.TabIndex = 2;
            this.correctErrorButton.Text = "Correct Error";
            this.correctErrorButton.UseVisualStyleBackColor = true;
            // 
            // r_EC_TextBox
            // 
            this.r_EC_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.r_EC_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r_EC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.r_EC_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_EC_TextBox.ForeColor = System.Drawing.Color.Black;
            this.r_EC_TextBox.Location = new System.Drawing.Point(103, 32);
            this.r_EC_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.r_EC_TextBox.Name = "r_EC_TextBox";
            this.r_EC_TextBox.Size = new System.Drawing.Size(594, 37);
            this.r_EC_TextBox.TabIndex = 0;
            this.r_EC_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Z(X) = ";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.S_EC_TextBox);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(8, 154);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(720, 135);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Syndrome Polynomial S(X)";
            // 
            // S_EC_TextBox
            // 
            this.S_EC_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.S_EC_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.S_EC_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.S_EC_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_EC_TextBox.ForeColor = System.Drawing.Color.Black;
            this.S_EC_TextBox.Location = new System.Drawing.Point(103, 49);
            this.S_EC_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.S_EC_TextBox.Name = "S_EC_TextBox";
            this.S_EC_TextBox.ReadOnly = true;
            this.S_EC_TextBox.Size = new System.Drawing.Size(594, 37);
            this.S_EC_TextBox.TabIndex = 0;
            this.S_EC_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 29);
            this.label12.TabIndex = 1;
            this.label12.Text = "S(X) = ";
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.BackgroundImage = global::ConvolutionalCodes.Properties.Resources.Wooden_Background;
            this.aboutTabPage.Controls.Add(this.label15);
            this.aboutTabPage.Controls.Add(this.label16);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 27);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(726, 433);
            this.aboutTabPage.TabIndex = 6;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Tomato;
            this.label15.Location = new System.Drawing.Point(134, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(302, 52);
            this.label15.TabIndex = 0;
            this.label15.Text = "Jaspreet Kaleka";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(134, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(354, 416);
            this.label16.TabIndex = 1;
            this.label16.Text = "Convolutional Codes\r\nVersion 1.0.1.1\r\n\r\nDeveloped by:\r\n\r\n\r\n23 Oct, 2010\r\nTU, Pati" +
                "ala\r\n";
            // 
            // mainErrorProvider
            // 
            this.mainErrorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 464);
            this.Controls.Add(this.mainTabControl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convolutional Codes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.inputTabPage.ResumeLayout(false);
            this.inputTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gXDataGridView)).EndInit();
            this.codewordsTabPage.ResumeLayout(false);
            this.codewordsTabPage.PerformLayout();
            this.errorDetectionTabPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.errorCorrectionTabPage.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage inputTabPage;
        private System.Windows.Forms.TextBox K_CL_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox k_TextBox;
        private System.Windows.Forms.TextBox n_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage codewordsTabPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox U_TextBox;
        private System.Windows.Forms.TabPage errorDetectionTabPage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label S_ED_Label;
        private System.Windows.Forms.TextBox S_ED_TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button rol_ED_Button;
        private System.Windows.Forms.Button ror_ED_Button;
        private System.Windows.Forms.Button detectErrorButton;
        private System.Windows.Forms.TextBox r_ED_TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage errorCorrectionTabPage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox U_EC_TextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button correctErrorButton;
        private System.Windows.Forms.TextBox r_EC_TextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox S_EC_TextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView gXDataGridView;
        private System.Windows.Forms.ErrorProvider mainErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gXColumn;


    }
}

