namespace NewCalc
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnRadical = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.lblCurrentOperation = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorGreutateSpecificaTeviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnMemoryRemember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioOvale = new System.Windows.Forms.RadioButton();
            this.radioCorniere = new System.Windows.Forms.RadioButton();
            this.radioRectangulare = new System.Windows.Forms.RadioButton();
            this.radioRotunde = new System.Windows.Forms.RadioButton();
            this.lblErrorLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGreutate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbThickness = new System.Windows.Forms.TextBox();
            this.tbDim2 = new System.Windows.Forms.TextBox();
            this.tbDim1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioRoundPrecision = new System.Windows.Forms.RadioButton();
            this.radioLBended = new System.Windows.Forms.RadioButton();
            this.radio10255 = new System.Windows.Forms.RadioButton();
            this.radioSF03 = new System.Windows.Forms.RadioButton();
            this.radio10217 = new System.Windows.Forms.RadioButton();
            this.radioConstruction = new System.Windows.Forms.RadioButton();
            this.radioSquarePrecision = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 502);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 69);
            this.btn0.TabIndex = 0;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(108, 502);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(90, 69);
            this.btnDecimal.TabIndex = 0;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(300, 502);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 69);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.operatorClicked);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(396, 502);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(89, 69);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 427);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 69);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(108, 427);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 69);
            this.btn2.TabIndex = 0;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(204, 427);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 69);
            this.btn3.TabIndex = 0;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(300, 427);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(90, 69);
            this.btnSubtract.TabIndex = 0;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.operatorClicked);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 352);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 69);
            this.btn4.TabIndex = 0;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(108, 352);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 69);
            this.btn5.TabIndex = 0;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(204, 352);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 69);
            this.btn6.TabIndex = 0;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(300, 352);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(90, 69);
            this.btnMultiply.TabIndex = 0;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.operatorClicked);
            // 
            // btnRadical
            // 
            this.btnRadical.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadical.Location = new System.Drawing.Point(395, 427);
            this.btnRadical.Name = "btnRadical";
            this.btnRadical.Size = new System.Drawing.Size(90, 69);
            this.btnRadical.TabIndex = 0;
            this.btnRadical.TabStop = false;
            this.btnRadical.Text = "√";
            this.btnRadical.UseVisualStyleBackColor = true;
            this.btnRadical.Click += new System.EventHandler(this.btnRadical_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 277);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 69);
            this.btn7.TabIndex = 0;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(108, 277);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 69);
            this.btn8.TabIndex = 0;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(204, 277);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 69);
            this.btn9.TabIndex = 0;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(300, 277);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(90, 69);
            this.btnDivide.TabIndex = 0;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.operatorClicked);
            // 
            // btnInverse
            // 
            this.btnInverse.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverse.Location = new System.Drawing.Point(395, 352);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(90, 69);
            this.btnInverse.TabIndex = 0;
            this.btnInverse.TabStop = false;
            this.btnInverse.Text = "1 / x";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(395, 277);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(90, 69);
            this.btnP.TabIndex = 0;
            this.btnP.TabStop = false;
            this.btnP.Text = "%";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.Location = new System.Drawing.Point(12, 202);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(90, 69);
            this.btnClearEntry.TabIndex = 0;
            this.btnClearEntry.TabStop = false;
            this.btnClearEntry.Text = "C E";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(13, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(472, 40);
            this.btnClear.TabIndex = 0;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.Location = new System.Drawing.Point(395, 202);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(90, 69);
            this.btnErase.TabIndex = 0;
            this.btnErase.TabStop = false;
            this.btnErase.Text = "←";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSign.Location = new System.Drawing.Point(204, 502);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(90, 69);
            this.btnChangeSign.TabIndex = 0;
            this.btnChangeSign.TabStop = false;
            this.btnChangeSign.Text = "+ / -";
            this.btnChangeSign.UseVisualStyleBackColor = true;
            this.btnChangeSign.Click += new System.EventHandler(this.btnChangeSign_Click);
            // 
            // btnMemoryAdd
            // 
            this.btnMemoryAdd.BackColor = System.Drawing.Color.Lime;
            this.btnMemoryAdd.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryAdd.Location = new System.Drawing.Point(108, 202);
            this.btnMemoryAdd.Name = "btnMemoryAdd";
            this.btnMemoryAdd.Size = new System.Drawing.Size(90, 69);
            this.btnMemoryAdd.TabIndex = 0;
            this.btnMemoryAdd.TabStop = false;
            this.btnMemoryAdd.Text = "M+";
            this.btnMemoryAdd.UseVisualStyleBackColor = false;
            this.btnMemoryAdd.Click += new System.EventHandler(this.btnMemoryAdd_Click);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.BackColor = System.Drawing.Color.Red;
            this.btnMemoryClear.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryClear.Location = new System.Drawing.Point(299, 202);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(90, 69);
            this.btnMemoryClear.TabIndex = 0;
            this.btnMemoryClear.TabStop = false;
            this.btnMemoryClear.Text = "M-";
            this.btnMemoryClear.UseVisualStyleBackColor = false;
            this.btnMemoryClear.Click += new System.EventHandler(this.btnMemoryClear_Click);
            // 
            // lblCurrentOperation
            // 
            this.lblCurrentOperation.AutoSize = true;
            this.lblCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOperation.Location = new System.Drawing.Point(19, 45);
            this.lblCurrentOperation.Name = "lblCurrentOperation";
            this.lblCurrentOperation.Size = new System.Drawing.Size(0, 31);
            this.lblCurrentOperation.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.calculatorGreutateSpecificaTeviToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.fileToolStripMenuItem.Text = "Calculator";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // calculatorGreutateSpecificaTeviToolStripMenuItem
            // 
            this.calculatorGreutateSpecificaTeviToolStripMenuItem.Name = "calculatorGreutateSpecificaTeviToolStripMenuItem";
            this.calculatorGreutateSpecificaTeviToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.calculatorGreutateSpecificaTeviToolStripMenuItem.Text = "Calculator greutate specifica tevi";
            this.calculatorGreutateSpecificaTeviToolStripMenuItem.Click += new System.EventHandler(this.calculatorGreutateSpecificaTeviToolStripMenuItem_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(13, 81);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(468, 69);
            this.tbResult.TabIndex = 6;
            this.tbResult.TabStop = false;
            this.tbResult.Text = "0";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbResult.TextChanged += new System.EventHandler(this.tbCorrect);
            // 
            // btnMemoryRemember
            // 
            this.btnMemoryRemember.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryRemember.Location = new System.Drawing.Point(204, 202);
            this.btnMemoryRemember.Name = "btnMemoryRemember";
            this.btnMemoryRemember.Size = new System.Drawing.Size(90, 69);
            this.btnMemoryRemember.TabIndex = 0;
            this.btnMemoryRemember.TabStop = false;
            this.btnMemoryRemember.Text = "M R";
            this.btnMemoryRemember.UseVisualStyleBackColor = true;
            this.btnMemoryRemember.Click += new System.EventHandler(this.btnMemoryRemember_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblErrorLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblGreutate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbThickness);
            this.groupBox1.Controls.Add(this.tbDim2);
            this.groupBox1.Controls.Add(this.tbDim1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(508, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 520);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator greutate specifica tevi si corniere";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioOvale);
            this.groupBox3.Controls.Add(this.radioCorniere);
            this.groupBox3.Controls.Add(this.radioRectangulare);
            this.groupBox3.Controls.Add(this.radioRotunde);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(16, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 83);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecteaza forma";
            // 
            // radioOvale
            // 
            this.radioOvale.AutoSize = true;
            this.radioOvale.Location = new System.Drawing.Point(7, 52);
            this.radioOvale.Name = "radioOvale";
            this.radioOvale.Size = new System.Drawing.Size(67, 24);
            this.radioOvale.TabIndex = 0;
            this.radioOvale.TabStop = true;
            this.radioOvale.Text = "Ovale";
            this.radioOvale.UseVisualStyleBackColor = true;
            this.radioOvale.Click += new System.EventHandler(this.Select_Shape);
            // 
            // radioCorniere
            // 
            this.radioCorniere.AutoSize = true;
            this.radioCorniere.Location = new System.Drawing.Point(186, 52);
            this.radioCorniere.Name = "radioCorniere";
            this.radioCorniere.Size = new System.Drawing.Size(87, 24);
            this.radioCorniere.TabIndex = 0;
            this.radioCorniere.TabStop = true;
            this.radioCorniere.Text = "Corniere";
            this.radioCorniere.UseVisualStyleBackColor = true;
            this.radioCorniere.Click += new System.EventHandler(this.Select_Shape);
            // 
            // radioRectangulare
            // 
            this.radioRectangulare.AutoSize = true;
            this.radioRectangulare.Location = new System.Drawing.Point(186, 26);
            this.radioRectangulare.Name = "radioRectangulare";
            this.radioRectangulare.Size = new System.Drawing.Size(123, 24);
            this.radioRectangulare.TabIndex = 0;
            this.radioRectangulare.TabStop = true;
            this.radioRectangulare.Text = "Rectangulare";
            this.radioRectangulare.UseVisualStyleBackColor = true;
            this.radioRectangulare.Click += new System.EventHandler(this.Select_Shape);
            // 
            // radioRotunde
            // 
            this.radioRotunde.AutoSize = true;
            this.radioRotunde.Checked = true;
            this.radioRotunde.Location = new System.Drawing.Point(7, 26);
            this.radioRotunde.Name = "radioRotunde";
            this.radioRotunde.Size = new System.Drawing.Size(89, 24);
            this.radioRotunde.TabIndex = 0;
            this.radioRotunde.TabStop = true;
            this.radioRotunde.Text = "Rotunde";
            this.radioRotunde.UseVisualStyleBackColor = true;
            this.radioRotunde.Click += new System.EventHandler(this.Select_Shape);
            // 
            // lblErrorLabel
            // 
            this.lblErrorLabel.AutoSize = true;
            this.lblErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLabel.Location = new System.Drawing.Point(18, 433);
            this.lblErrorLabel.Name = "lblErrorLabel";
            this.lblErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.lblErrorLabel.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "-----------------------------------------------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "kg/ml";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "mm.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "mm.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "mm.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lat1 sau Diam.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Greut. Spec.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grosime";
            // 
            // lblGreutate
            // 
            this.lblGreutate.AutoSize = true;
            this.lblGreutate.Location = new System.Drawing.Point(179, 376);
            this.lblGreutate.Name = "lblGreutate";
            this.lblGreutate.Size = new System.Drawing.Size(0, 24);
            this.lblGreutate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lat 2";
            // 
            // tbThickness
            // 
            this.tbThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbThickness.Location = new System.Drawing.Point(169, 327);
            this.tbThickness.Name = "tbThickness";
            this.tbThickness.Size = new System.Drawing.Size(100, 29);
            this.tbThickness.TabIndex = 3;
            this.tbThickness.TextChanged += new System.EventHandler(this.tbTextChanged);
            // 
            // tbDim2
            // 
            this.tbDim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDim2.Location = new System.Drawing.Point(169, 294);
            this.tbDim2.Name = "tbDim2";
            this.tbDim2.Size = new System.Drawing.Size(100, 29);
            this.tbDim2.TabIndex = 2;
            this.tbDim2.TextChanged += new System.EventHandler(this.tbTextChanged);
            // 
            // tbDim1
            // 
            this.tbDim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDim1.Location = new System.Drawing.Point(169, 261);
            this.tbDim1.Name = "tbDim1";
            this.tbDim1.Size = new System.Drawing.Size(100, 29);
            this.tbDim1.TabIndex = 1;
            this.tbDim1.TextChanged += new System.EventHandler(this.tbTextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioRoundPrecision);
            this.groupBox2.Controls.Add(this.radioLBended);
            this.groupBox2.Controls.Add(this.radio10255);
            this.groupBox2.Controls.Add(this.radioSF03);
            this.groupBox2.Controls.Add(this.radio10217);
            this.groupBox2.Controls.Add(this.radioConstruction);
            this.groupBox2.Controls.Add(this.radioSquarePrecision);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(16, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 112);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Standard de fabricatie";
            // 
            // radioRoundPrecision
            // 
            this.radioRoundPrecision.AutoSize = true;
            this.radioRoundPrecision.Checked = true;
            this.radioRoundPrecision.Location = new System.Drawing.Point(7, 24);
            this.radioRoundPrecision.Name = "radioRoundPrecision";
            this.radioRoundPrecision.Size = new System.Drawing.Size(112, 24);
            this.radioRoundPrecision.TabIndex = 0;
            this.radioRoundPrecision.TabStop = true;
            this.radioRoundPrecision.Text = "EN 10305-3";
            this.radioRoundPrecision.UseVisualStyleBackColor = true;
            this.radioRoundPrecision.Click += new System.EventHandler(this.Standard_Selection);
            // 
            // radioLBended
            // 
            this.radioLBended.AutoSize = true;
            this.radioLBended.ForeColor = System.Drawing.Color.Red;
            this.radioLBended.Location = new System.Drawing.Point(7, 82);
            this.radioLBended.Name = "radioLBended";
            this.radioLBended.Size = new System.Drawing.Size(98, 24);
            this.radioLBended.TabIndex = 0;
            this.radioLBended.Text = "EN 10162";
            this.radioLBended.UseVisualStyleBackColor = true;
            this.radioLBended.Click += new System.EventHandler(this.Standard_Selection);
            // 
            // radio10255
            // 
            this.radio10255.AutoSize = true;
            this.radio10255.Location = new System.Drawing.Point(243, 53);
            this.radio10255.Name = "radio10255";
            this.radio10255.Size = new System.Drawing.Size(98, 24);
            this.radio10255.TabIndex = 0;
            this.radio10255.Text = "EN 10255";
            this.radio10255.UseVisualStyleBackColor = true;
            this.radio10255.Click += new System.EventHandler(this.Standard_Selection);
            // 
            // radioSF03
            // 
            this.radioSF03.AutoSize = true;
            this.radioSF03.Location = new System.Drawing.Point(243, 25);
            this.radioSF03.Name = "radioSF03";
            this.radioSF03.Size = new System.Drawing.Size(70, 24);
            this.radioSF03.TabIndex = 0;
            this.radioSF03.Text = "SF 03";
            this.radioSF03.UseVisualStyleBackColor = true;
            this.radioSF03.Click += new System.EventHandler(this.Standard_Selection);
            // 
            // radio10217
            // 
            this.radio10217.AutoSize = true;
            this.radio10217.Location = new System.Drawing.Point(125, 53);
            this.radio10217.Name = "radio10217";
            this.radio10217.Size = new System.Drawing.Size(112, 24);
            this.radio10217.TabIndex = 0;
            this.radio10217.Text = "EN 10217-1";
            this.radio10217.UseVisualStyleBackColor = true;
            this.radio10217.Click += new System.EventHandler(this.Standard_Selection);
            // 
            // radioConstruction
            // 
            this.radioConstruction.AutoSize = true;
            this.radioConstruction.Location = new System.Drawing.Point(7, 53);
            this.radioConstruction.Name = "radioConstruction";
            this.radioConstruction.Size = new System.Drawing.Size(112, 24);
            this.radioConstruction.TabIndex = 0;
            this.radioConstruction.Text = "EN 10219-2";
            this.radioConstruction.UseVisualStyleBackColor = true;
            this.radioConstruction.Click += new System.EventHandler(this.Standard_Selection);
            // 
            // radioSquarePrecision
            // 
            this.radioSquarePrecision.AutoSize = true;
            this.radioSquarePrecision.Location = new System.Drawing.Point(125, 25);
            this.radioSquarePrecision.Name = "radioSquarePrecision";
            this.radioSquarePrecision.Size = new System.Drawing.Size(112, 24);
            this.radioSquarePrecision.TabIndex = 0;
            this.radioSquarePrecision.Text = "EN 10305-5";
            this.radioSquarePrecision.UseVisualStyleBackColor = true;
            this.radioSquarePrecision.Click += new System.EventHandler(this.Standard_Selection);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(838, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "© Marius Simion";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(965, 589);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblCurrentOperation);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnRadical);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.btnMemoryRemember);
            this.Controls.Add(this.btnMemoryAdd);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnChangeSign);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnRadical;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Label lblCurrentOperation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ToolStripMenuItem calculatorGreutateSpecificaTeviToolStripMenuItem;
        private System.Windows.Forms.Button btnMemoryRemember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioRoundPrecision;
        private System.Windows.Forms.RadioButton radioLBended;
        private System.Windows.Forms.RadioButton radio10255;
        private System.Windows.Forms.RadioButton radio10217;
        private System.Windows.Forms.RadioButton radioConstruction;
        private System.Windows.Forms.RadioButton radioSquarePrecision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThickness;
        private System.Windows.Forms.TextBox tbDim2;
        private System.Windows.Forms.TextBox tbDim1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGreutate;
        private System.Windows.Forms.RadioButton radioSF03;
        private System.Windows.Forms.Label lblErrorLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioOvale;
        private System.Windows.Forms.RadioButton radioCorniere;
        private System.Windows.Forms.RadioButton radioRectangulare;
        private System.Windows.Forms.RadioButton radioRotunde;
        private System.Windows.Forms.Label label10;
    }
}

