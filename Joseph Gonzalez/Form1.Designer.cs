namespace Joseph_Gonzalez
{
    partial class MembershipForm
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
            this.membershipGroupBox = new System.Windows.Forms.GroupBox();
            this.standardadultRadioButton = new System.Windows.Forms.RadioButton();
            this.childRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.seniorcitizenRadioButton = new System.Windows.Forms.RadioButton();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.yogaCheckBox = new System.Windows.Forms.CheckBox();
            this.membershiplengthGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.karateCheckBox = new System.Windows.Forms.CheckBox();
            this.personaltrainerCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberMoths = new System.Windows.Forms.TextBox();
            this.monthlyfeeLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalL = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.TextBox();
            this.monthlyFeeL = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.membershipGroupBox.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.membershiplengthGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // membershipGroupBox
            // 
            this.membershipGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.membershipGroupBox.Controls.Add(this.seniorcitizenRadioButton);
            this.membershipGroupBox.Controls.Add(this.studentRadioButton);
            this.membershipGroupBox.Controls.Add(this.childRadioButton);
            this.membershipGroupBox.Controls.Add(this.standardadultRadioButton);
            this.membershipGroupBox.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipGroupBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.membershipGroupBox.Location = new System.Drawing.Point(78, 65);
            this.membershipGroupBox.Name = "membershipGroupBox";
            this.membershipGroupBox.Size = new System.Drawing.Size(246, 153);
            this.membershipGroupBox.TabIndex = 1;
            this.membershipGroupBox.TabStop = false;
            this.membershipGroupBox.Text = "Type of Membership";
            // 
            // standardadultRadioButton
            // 
            this.standardadultRadioButton.AutoSize = true;
            this.standardadultRadioButton.BackColor = System.Drawing.Color.LightBlue;
            this.standardadultRadioButton.Location = new System.Drawing.Point(6, 25);
            this.standardadultRadioButton.Name = "standardadultRadioButton";
            this.standardadultRadioButton.Size = new System.Drawing.Size(154, 25);
            this.standardadultRadioButton.TabIndex = 2;
            this.standardadultRadioButton.TabStop = true;
            this.standardadultRadioButton.Text = "Standard &Adult";
            this.standardadultRadioButton.UseVisualStyleBackColor = false;
            // 
            // childRadioButton
            // 
            this.childRadioButton.AutoSize = true;
            this.childRadioButton.Location = new System.Drawing.Point(6, 56);
            this.childRadioButton.Name = "childRadioButton";
            this.childRadioButton.Size = new System.Drawing.Size(197, 25);
            this.childRadioButton.TabIndex = 3;
            this.childRadioButton.TabStop = true;
            this.childRadioButton.Text = "Chi&ld (12 and under)";
            this.childRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(6, 87);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(95, 25);
            this.studentRadioButton.TabIndex = 4;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "&Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // seniorcitizenRadioButton
            // 
            this.seniorcitizenRadioButton.AutoSize = true;
            this.seniorcitizenRadioButton.Location = new System.Drawing.Point(6, 118);
            this.seniorcitizenRadioButton.Name = "seniorcitizenRadioButton";
            this.seniorcitizenRadioButton.Size = new System.Drawing.Size(143, 25);
            this.seniorcitizenRadioButton.TabIndex = 5;
            this.seniorcitizenRadioButton.TabStop = true;
            this.seniorcitizenRadioButton.Text = "&Senior Citizen";
            this.seniorcitizenRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.optionsGroupBox.Controls.Add(this.personaltrainerCheckBox);
            this.optionsGroupBox.Controls.Add(this.karateCheckBox);
            this.optionsGroupBox.Controls.Add(this.yogaCheckBox);
            this.optionsGroupBox.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.optionsGroupBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.optionsGroupBox.Location = new System.Drawing.Point(374, 77);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(200, 111);
            this.optionsGroupBox.TabIndex = 6;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // yogaCheckBox
            // 
            this.yogaCheckBox.AutoSize = true;
            this.yogaCheckBox.Location = new System.Drawing.Point(3, 18);
            this.yogaCheckBox.Name = "yogaCheckBox";
            this.yogaCheckBox.Size = new System.Drawing.Size(69, 25);
            this.yogaCheckBox.TabIndex = 0;
            this.yogaCheckBox.Text = "&Yoga";
            this.yogaCheckBox.UseVisualStyleBackColor = true;
            // 
            // membershiplengthGroupBox
            // 
            this.membershiplengthGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.membershiplengthGroupBox.Controls.Add(this.numberMoths);
            this.membershiplengthGroupBox.Controls.Add(this.label1);
            this.membershiplengthGroupBox.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.membershiplengthGroupBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.membershiplengthGroupBox.Location = new System.Drawing.Point(78, 224);
            this.membershiplengthGroupBox.Name = "membershiplengthGroupBox";
            this.membershiplengthGroupBox.Size = new System.Drawing.Size(265, 100);
            this.membershiplengthGroupBox.TabIndex = 1;
            this.membershiplengthGroupBox.TabStop = false;
            this.membershiplengthGroupBox.Text = "Membership Length";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.monthlyFeeL);
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.totalL);
            this.groupBox2.Controls.Add(this.monthlyfeeLabel);
            this.groupBox2.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(374, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 108);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Membership Fees";
            // 
            // karateCheckBox
            // 
            this.karateCheckBox.AutoSize = true;
            this.karateCheckBox.Location = new System.Drawing.Point(3, 49);
            this.karateCheckBox.Name = "karateCheckBox";
            this.karateCheckBox.Size = new System.Drawing.Size(89, 25);
            this.karateCheckBox.TabIndex = 1;
            this.karateCheckBox.Text = "&Karate";
            this.karateCheckBox.UseVisualStyleBackColor = true;
            this.karateCheckBox.CheckedChanged += new System.EventHandler(this.karateCheckBox_CheckedChanged);
            // 
            // personaltrainerCheckBox
            // 
            this.personaltrainerCheckBox.AutoSize = true;
            this.personaltrainerCheckBox.Location = new System.Drawing.Point(3, 75);
            this.personaltrainerCheckBox.Name = "personaltrainerCheckBox";
            this.personaltrainerCheckBox.Size = new System.Drawing.Size(167, 25);
            this.personaltrainerCheckBox.TabIndex = 2;
            this.personaltrainerCheckBox.Text = "&Personal Trainer";
            this.personaltrainerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Number of Moths:";
            // 
            // numberMoths
            // 
            this.numberMoths.BackColor = System.Drawing.Color.LightCyan;
            this.numberMoths.Location = new System.Drawing.Point(35, 49);
            this.numberMoths.Name = "numberMoths";
            this.numberMoths.Size = new System.Drawing.Size(168, 29);
            this.numberMoths.TabIndex = 1;
            // 
            // monthlyfeeLabel
            // 
            this.monthlyfeeLabel.AutoSize = true;
            this.monthlyfeeLabel.Location = new System.Drawing.Point(6, 25);
            this.monthlyfeeLabel.Name = "monthlyfeeLabel";
            this.monthlyfeeLabel.Size = new System.Drawing.Size(114, 21);
            this.monthlyfeeLabel.TabIndex = 7;
            this.monthlyfeeLabel.Text = "Monthly Fee:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(30, 69);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(59, 21);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total:";
            // 
            // totalL
            // 
            this.totalL.BackColor = System.Drawing.Color.LightCyan;
            this.totalL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalL.Location = new System.Drawing.Point(127, 67);
            this.totalL.Name = "totalL";
            this.totalL.Size = new System.Drawing.Size(94, 23);
            this.totalL.TabIndex = 8;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombre.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.nombre.Location = new System.Drawing.Point(69, 3);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(77, 21);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "Nombre:";
            this.nombre.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(143, 3);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(242, 22);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.TextChanged += new System.EventHandler(this.lblFirstName_TextChanged);
            // 
            // monthlyFeeL
            // 
            this.monthlyFeeL.BackColor = System.Drawing.Color.LightCyan;
            this.monthlyFeeL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monthlyFeeL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.monthlyFeeL.Location = new System.Drawing.Point(126, 25);
            this.monthlyFeeL.Name = "monthlyFeeL";
            this.monthlyFeeL.Size = new System.Drawing.Size(95, 23);
            this.monthlyFeeL.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculateButton.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.calculateButton.Location = new System.Drawing.Point(85, 354);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(107, 49);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearButton.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.clearButton.Location = new System.Drawing.Point(296, 354);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 49);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightCoral;
            this.exitButton.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(510, 354);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 49);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1030, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1030, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(546, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(242, 22);
            this.txtLastName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(404, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido:";
            // 
            // MembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1030, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.membershiplengthGroupBox);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.membershipGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MembershipForm";
            this.Text = "Membership Fee Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.membershipGroupBox.ResumeLayout(false);
            this.membershipGroupBox.PerformLayout();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.membershiplengthGroupBox.ResumeLayout(false);
            this.membershiplengthGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox membershipGroupBox;
        private System.Windows.Forms.RadioButton standardadultRadioButton;
        private System.Windows.Forms.RadioButton seniorcitizenRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton childRadioButton;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox yogaCheckBox;
        private System.Windows.Forms.GroupBox membershiplengthGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox personaltrainerCheckBox;
        private System.Windows.Forms.CheckBox karateCheckBox;
        private System.Windows.Forms.TextBox numberMoths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label monthlyfeeLabel;
        private System.Windows.Forms.Label totalL;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label monthlyFeeL;
        private System.Windows.Forms.TextBox lblFirstName;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
    }
}

