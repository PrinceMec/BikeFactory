namespace BikeFactory.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBikeType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtserialnumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSuspensiontype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTireType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstbikes = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbRoad = new System.Windows.Forms.RadioButton();
            this.rbMountain = new System.Windows.Forms.RadioButton();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtoriginialserialnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(393, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bike Factory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(167, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bike Type:";
            // 
            // cbBikeType
            // 
            this.cbBikeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBikeType.FormattingEnabled = true;
            this.cbBikeType.Items.AddRange(new object[] {
            "Mountain",
            "Road"});
            this.cbBikeType.Location = new System.Drawing.Point(167, 147);
            this.cbBikeType.Name = "cbBikeType";
            this.cbBikeType.Size = new System.Drawing.Size(151, 28);
            this.cbBikeType.TabIndex = 2;
            this.cbBikeType.SelectedIndexChanged += new System.EventHandler(this.cbBikeType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(362, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Serial no:";
            // 
            // txtserialnumber
            // 
            this.txtserialnumber.Location = new System.Drawing.Point(364, 147);
            this.txtserialnumber.Name = "txtserialnumber";
            this.txtserialnumber.Size = new System.Drawing.Size(151, 27);
            this.txtserialnumber.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(563, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 27);
            this.txtName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(561, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(752, 146);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(151, 27);
            this.txtModel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(750, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Model:";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Orange",
            "Blue",
            "Green"});
            this.cbColor.Location = new System.Drawing.Point(167, 243);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(151, 28);
            this.cbColor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(167, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Color:";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(366, 242);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(151, 27);
            this.txtyear.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(362, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Construct Year:";
            // 
            // cbSuspensiontype
            // 
            this.cbSuspensiontype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuspensiontype.FormattingEnabled = true;
            this.cbSuspensiontype.Items.AddRange(new object[] {
            "Front",
            "Rear",
            "Dual"});
            this.cbSuspensiontype.Location = new System.Drawing.Point(563, 243);
            this.cbSuspensiontype.Name = "cbSuspensiontype";
            this.cbSuspensiontype.Size = new System.Drawing.Size(151, 28);
            this.cbSuspensiontype.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(563, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "SuspensionType:";
            // 
            // cbTireType
            // 
            this.cbTireType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTireType.FormattingEnabled = true;
            this.cbTireType.Items.AddRange(new object[] {
            "Regular",
            "Commuter",
            "Gravel"});
            this.cbTireType.Location = new System.Drawing.Point(750, 243);
            this.cbTireType.Name = "cbTireType";
            this.cbTireType.Size = new System.Drawing.Size(151, 28);
            this.cbTireType.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(750, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tire Type:";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(167, 290);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(348, 55);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(561, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(342, 55);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstbikes
            // 
            this.lstbikes.FormattingEnabled = true;
            this.lstbikes.ItemHeight = 20;
            this.lstbikes.Location = new System.Drawing.Point(12, 406);
            this.lstbikes.Name = "lstbikes";
            this.lstbikes.Size = new System.Drawing.Size(1052, 264);
            this.lstbikes.TabIndex = 19;
            this.lstbikes.SelectedIndexChanged += new System.EventHandler(this.lstbikes_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(166, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "Select List Type:";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(320, 366);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(48, 24);
            this.rbAll.TabIndex = 21;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbRoad
            // 
            this.rbRoad.AutoSize = true;
            this.rbRoad.Location = new System.Drawing.Point(467, 366);
            this.rbRoad.Name = "rbRoad";
            this.rbRoad.Size = new System.Drawing.Size(65, 24);
            this.rbRoad.TabIndex = 22;
            this.rbRoad.Text = "Road";
            this.rbRoad.UseVisualStyleBackColor = true;
            this.rbRoad.CheckedChanged += new System.EventHandler(this.rbRoad_CheckedChanged);
            // 
            // rbMountain
            // 
            this.rbMountain.AutoSize = true;
            this.rbMountain.Location = new System.Drawing.Point(374, 366);
            this.rbMountain.Name = "rbMountain";
            this.rbMountain.Size = new System.Drawing.Size(93, 24);
            this.rbMountain.TabIndex = 23;
            this.rbMountain.Text = "Mountain";
            this.rbMountain.UseVisualStyleBackColor = true;
            this.rbMountain.CheckedChanged += new System.EventHandler(this.rbMountain_CheckedChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(12, 676);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(260, 47);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(792, 676);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(272, 47);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(534, 676);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 47);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(278, 676);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(250, 47);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(712, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Originial S.no:";
            // 
            // txtoriginialserialnumber
            // 
            this.txtoriginialserialnumber.Enabled = false;
            this.txtoriginialserialnumber.Location = new System.Drawing.Point(819, 365);
            this.txtoriginialserialnumber.Name = "txtoriginialserialnumber";
            this.txtoriginialserialnumber.Size = new System.Drawing.Size(84, 27);
            this.txtoriginialserialnumber.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 747);
            this.Controls.Add(this.txtoriginialserialnumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.rbMountain);
            this.Controls.Add(this.rbRoad);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstbikes);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbTireType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSuspensiontype);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtserialnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBikeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbBikeType;
        private Label label3;
        private TextBox txtserialnumber;
        private TextBox txtName;
        private Label label4;
        private TextBox txtModel;
        private Label label5;
        private ComboBox cbColor;
        private Label label6;
        private TextBox txtyear;
        private Label label7;
        private ComboBox cbSuspensiontype;
        private Label label8;
        private ComboBox cbTireType;
        private Label label9;
        private Button btnadd;
        private Button btnUpdate;
        private ListBox lstbikes;
        private Label label10;
        private RadioButton rbAll;
        private RadioButton rbRoad;
        private RadioButton rbMountain;
        private Button btnRemove;
        private Button btnExit;
        private Button btnSave;
        private Button btnSearch;
        private Label label11;
        private TextBox txtoriginialserialnumber;
    }
}