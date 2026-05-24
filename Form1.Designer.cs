namespace Lab5_Debugging
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLinear = new System.Windows.Forms.TabPage();
            this.txtIntermediate = new System.Windows.Forms.TextBox();
            this.lblIntermediate = new System.Windows.Forms.Label();
            this.btnClearLinear = new System.Windows.Forms.Button();
            this.btnCalculateLinear = new System.Windows.Forms.Button();
            this.txtResult_Linear = new System.Windows.Forms.TextBox();
            this.lblResult_Linear = new System.Windows.Forms.Label();
            this.txtZ_Linear = new System.Windows.Forms.TextBox();
            this.lblZ_Linear = new System.Windows.Forms.Label();
            this.txtY_Linear = new System.Windows.Forms.TextBox();
            this.txtX_Linear = new System.Windows.Forms.TextBox();
            this.lblY_Linear = new System.Windows.Forms.Label();
            this.lblX_Linear = new System.Windows.Forms.Label();
            this.lblTitle_Linear = new System.Windows.Forms.Label();
            this.tabPageBranch = new System.Windows.Forms.TabPage();
            this.btnClearBranch = new System.Windows.Forms.Button();
            this.btnCalculateBranch = new System.Windows.Forms.Button();
            this.txtFxValue = new System.Windows.Forms.TextBox();
            this.lblFxValue = new System.Windows.Forms.Label();
            this.txtFormulaUsed = new System.Windows.Forms.TextBox();
            this.lblFormulaUsed = new System.Windows.Forms.Label();
            this.txtResult_Branch = new System.Windows.Forms.TextBox();
            this.lblResult_Branch = new System.Windows.Forms.Label();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.txtY_Branch = new System.Windows.Forms.TextBox();
            this.txtX_Branch = new System.Windows.Forms.TextBox();
            this.lblY_Branch = new System.Windows.Forms.Label();
            this.lblX_Branch = new System.Windows.Forms.Label();
            this.lblTitle_Branch = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageLinear.SuspendLayout();
            this.tabPageBranch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLinear);
            this.tabControl1.Controls.Add(this.tabPageBranch);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 520);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageLinear
            // 
            this.tabPageLinear.Controls.Add(this.txtIntermediate);
            this.tabPageLinear.Controls.Add(this.lblIntermediate);
            this.tabPageLinear.Controls.Add(this.btnClearLinear);
            this.tabPageLinear.Controls.Add(this.btnCalculateLinear);
            this.tabPageLinear.Controls.Add(this.txtResult_Linear);
            this.tabPageLinear.Controls.Add(this.lblResult_Linear);
            this.tabPageLinear.Controls.Add(this.txtZ_Linear);
            this.tabPageLinear.Controls.Add(this.lblZ_Linear);
            this.tabPageLinear.Controls.Add(this.txtY_Linear);
            this.tabPageLinear.Controls.Add(this.txtX_Linear);
            this.tabPageLinear.Controls.Add(this.lblY_Linear);
            this.tabPageLinear.Controls.Add(this.lblX_Linear);
            this.tabPageLinear.Controls.Add(this.lblTitle_Linear);
            this.tabPageLinear.Location = new System.Drawing.Point(4, 22);
            this.tabPageLinear.Name = "tabPageLinear";
            this.tabPageLinear.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLinear.Size = new System.Drawing.Size(752, 494);
            this.tabPageLinear.TabIndex = 0;
            this.tabPageLinear.Text = "Линейный алгоритм";
            this.tabPageLinear.UseVisualStyleBackColor = true;
            // 
            // lblTitle_Linear
            // 
            this.lblTitle_Linear.AutoSize = true;
            this.lblTitle_Linear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle_Linear.Location = new System.Drawing.Point(100, 20);
            this.lblTitle_Linear.Name = "lblTitle_Linear";
            this.lblTitle_Linear.Size = new System.Drawing.Size(550, 34);
            this.lblTitle_Linear.TabIndex = 0;
            this.lblTitle_Linear.Text = "Линейный алгоритм:\r\nu = tg²(x + y) - e^(y-z) · √(cos²x + sin²z)";
            // 
            // lblX_Linear
            // 
            this.lblX_Linear.AutoSize = true;
            this.lblX_Linear.Location = new System.Drawing.Point(150, 80);
            this.lblX_Linear.Name = "lblX_Linear";
            this.lblX_Linear.Size = new System.Drawing.Size(80, 13);
            this.lblX_Linear.TabIndex = 1;
            this.lblX_Linear.Text = "Введите X:";
            // 
            // lblY_Linear
            // 
            this.lblY_Linear.AutoSize = true;
            this.lblY_Linear.Location = new System.Drawing.Point(150, 120);
            this.lblY_Linear.Name = "lblY_Linear";
            this.lblY_Linear.Size = new System.Drawing.Size(80, 13);
            this.lblY_Linear.TabIndex = 2;
            this.lblY_Linear.Text = "Введите Y:";
            // 
            // lblZ_Linear
            // 
            this.lblZ_Linear.AutoSize = true;
            this.lblZ_Linear.Location = new System.Drawing.Point(150, 160);
            this.lblZ_Linear.Name = "lblZ_Linear";
            this.lblZ_Linear.Size = new System.Drawing.Size(80, 13);
            this.lblZ_Linear.TabIndex = 9;
            this.lblZ_Linear.Text = "Введите Z:";
            // 
            // txtX_Linear
            // 
            this.txtX_Linear.Location = new System.Drawing.Point(250, 77);
            this.txtX_Linear.Name = "txtX_Linear";
            this.txtX_Linear.Size = new System.Drawing.Size(200, 20);
            this.txtX_Linear.TabIndex = 3;
            // 
            // txtY_Linear
            // 
            this.txtY_Linear.Location = new System.Drawing.Point(250, 117);
            this.txtY_Linear.Name = "txtY_Linear";
            this.txtY_Linear.Size = new System.Drawing.Size(200, 20);
            this.txtY_Linear.TabIndex = 4;
            // 
            // txtZ_Linear
            // 
            this.txtZ_Linear.Location = new System.Drawing.Point(250, 157);
            this.txtZ_Linear.Name = "txtZ_Linear";
            this.txtZ_Linear.Size = new System.Drawing.Size(200, 20);
            this.txtZ_Linear.TabIndex = 10;
            // 
            // lblResult_Linear
            // 
            this.lblResult_Linear.AutoSize = true;
            this.lblResult_Linear.Location = new System.Drawing.Point(150, 200);
            this.lblResult_Linear.Name = "lblResult_Linear";
            this.lblResult_Linear.Size = new System.Drawing.Size(63, 13);
            this.lblResult_Linear.TabIndex = 5;
            this.lblResult_Linear.Text = "Результат:";
            // 
            // txtResult_Linear
            // 
            this.txtResult_Linear.BackColor = System.Drawing.SystemColors.Info;
            this.txtResult_Linear.Location = new System.Drawing.Point(250, 197);
            this.txtResult_Linear.Name = "txtResult_Linear";
            this.txtResult_Linear.ReadOnly = true;
            this.txtResult_Linear.Size = new System.Drawing.Size(200, 20);
            this.txtResult_Linear.TabIndex = 6;
            // 
            // lblIntermediate
            // 
            this.lblIntermediate.AutoSize = true;
            this.lblIntermediate.Location = new System.Drawing.Point(150, 240);
            this.lblIntermediate.Name = "lblIntermediate";
            this.lblIntermediate.Size = new System.Drawing.Size(140, 13);
            this.lblIntermediate.TabIndex = 11;
            this.lblIntermediate.Text = "Промежуточные значения:";
            // 
            // txtIntermediate
            // 
            this.txtIntermediate.BackColor = System.Drawing.SystemColors.Info;
            this.txtIntermediate.Location = new System.Drawing.Point(150, 260);
            this.txtIntermediate.Multiline = true;
            this.txtIntermediate.Name = "txtIntermediate";
            this.txtIntermediate.ReadOnly = true;
            this.txtIntermediate.Size = new System.Drawing.Size(450, 80);
            this.txtIntermediate.TabIndex = 12;
            // 
            // btnCalculateLinear
            // 
            this.btnCalculateLinear.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculateLinear.Location = new System.Drawing.Point(200, 360);
            this.btnCalculateLinear.Name = "btnCalculateLinear";
            this.btnCalculateLinear.Size = new System.Drawing.Size(100, 30);
            this.btnCalculateLinear.TabIndex = 7;
            this.btnCalculateLinear.Text = "Вычислить";
            this.btnCalculateLinear.UseVisualStyleBackColor = false;
            this.btnCalculateLinear.Click += new System.EventHandler(this.btnCalculateLinear_Click);
            // 
            // btnClearLinear
            // 
            this.btnClearLinear.Location = new System.Drawing.Point(320, 360);
            this.btnClearLinear.Name = "btnClearLinear";
            this.btnClearLinear.Size = new System.Drawing.Size(100, 30);
            this.btnClearLinear.TabIndex = 8;
            this.btnClearLinear.Text = "Очистить";
            this.btnClearLinear.UseVisualStyleBackColor = true;
            this.btnClearLinear.Click += new System.EventHandler(this.btnClearLinear_Click);
            // 
            // tabPageBranch
            // 
            this.tabPageBranch.Controls.Add(this.btnClearBranch);
            this.tabPageBranch.Controls.Add(this.btnCalculateBranch);
            this.tabPageBranch.Controls.Add(this.txtFxValue);
            this.tabPageBranch.Controls.Add(this.lblFxValue);
            this.tabPageBranch.Controls.Add(this.txtFormulaUsed);
            this.tabPageBranch.Controls.Add(this.lblFormulaUsed);
            this.tabPageBranch.Controls.Add(this.txtResult_Branch);
            this.tabPageBranch.Controls.Add(this.lblResult_Branch);
            this.tabPageBranch.Controls.Add(this.cmbFunction);
            this.tabPageBranch.Controls.Add(this.lblFunction);
            this.tabPageBranch.Controls.Add(this.txtY_Branch);
            this.tabPageBranch.Controls.Add(this.txtX_Branch);
            this.tabPageBranch.Controls.Add(this.lblY_Branch);
            this.tabPageBranch.Controls.Add(this.lblX_Branch);
            this.tabPageBranch.Controls.Add(this.lblTitle_Branch);
            this.tabPageBranch.Location = new System.Drawing.Point(4, 22);
            this.tabPageBranch.Name = "tabPageBranch";
            this.tabPageBranch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBranch.Size = new System.Drawing.Size(752, 494);
            this.tabPageBranch.TabIndex = 1;
            this.tabPageBranch.Text = "Разветвляющийся алгоритм";
            this.tabPageBranch.UseVisualStyleBackColor = true;
            // 
            // lblTitle_Branch
            // 
            this.lblTitle_Branch.AutoSize = true;
            this.lblTitle_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle_Branch.Location = new System.Drawing.Point(100, 20);
            this.lblTitle_Branch.Name = "lblTitle_Branch";
            this.lblTitle_Branch.Size = new System.Drawing.Size(550, 68);
            this.lblTitle_Branch.TabIndex = 0;
            this.lblTitle_Branch.Text = "Разветвляющийся алгоритм:\r\nf²(x) + arctg(f(x)),                    1 ≤ x < 5\r\n(y - f(x))² + arctg(f(x)),      y > x\r\n(y + f(x))³ + 0.5,                  иначе";
            // 
            // lblX_Branch
            // 
            this.lblX_Branch.AutoSize = true;
            this.lblX_Branch.Location = new System.Drawing.Point(150, 120);
            this.lblX_Branch.Name = "lblX_Branch";
            this.lblX_Branch.Size = new System.Drawing.Size(80, 13);
            this.lblX_Branch.TabIndex = 1;
            this.lblX_Branch.Text = "Введите X:";
            // 
            // lblY_Branch
            // 
            this.lblY_Branch.AutoSize = true;
            this.lblY_Branch.Location = new System.Drawing.Point(150, 160);
            this.lblY_Branch.Name = "lblY_Branch";
            this.lblY_Branch.Size = new System.Drawing.Size(80, 13);
            this.lblY_Branch.TabIndex = 2;
            this.lblY_Branch.Text = "Введите Y:";
            // 
            // txtX_Branch
            // 
            this.txtX_Branch.Location = new System.Drawing.Point(250, 117);
            this.txtX_Branch.Name = "txtX_Branch";
            this.txtX_Branch.Size = new System.Drawing.Size(200, 20);
            this.txtX_Branch.TabIndex = 3;
            // 
            // txtY_Branch
            // 
            this.txtY_Branch.Location = new System.Drawing.Point(250, 157);
            this.txtY_Branch.Name = "txtY_Branch";
            this.txtY_Branch.Size = new System.Drawing.Size(200, 20);
            this.txtY_Branch.TabIndex = 4;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(150, 200);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(90, 13);
            this.lblFunction.TabIndex = 5;
            this.lblFunction.Text = "Выберите f(x):";
            // 
            // cmbFunction
            // 
            this.cmbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunction.Items.AddRange(new object[] {
            "sin(x)",
            "cos(x)",
            "e^x",
            "x²"});
            this.cmbFunction.Location = new System.Drawing.Point(250, 197);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Size = new System.Drawing.Size(200, 21);
            this.cmbFunction.TabIndex = 6;
            this.cmbFunction.SelectedIndex = 0;
            // 
            // lblResult_Branch
            // 
            this.lblResult_Branch.AutoSize = true;
            this.lblResult_Branch.Location = new System.Drawing.Point(150, 240);
            this.lblResult_Branch.Name = "lblResult_Branch";
            this.lblResult_Branch.Size = new System.Drawing.Size(63, 13);
            this.lblResult_Branch.TabIndex = 7;
            this.lblResult_Branch.Text = "Результат:";
            // 
            // txtResult_Branch
            // 
            this.txtResult_Branch.BackColor = System.Drawing.SystemColors.Info;
            this.txtResult_Branch.Location = new System.Drawing.Point(250, 237);
            this.txtResult_Branch.Name = "txtResult_Branch";
            this.txtResult_Branch.ReadOnly = true;
            this.txtResult_Branch.Size = new System.Drawing.Size(200, 20);
            this.txtResult_Branch.TabIndex = 8;
            // 
            // lblFormulaUsed
            // 
            this.lblFormulaUsed.AutoSize = true;
            this.lblFormulaUsed.Location = new System.Drawing.Point(150, 280);
            this.lblFormulaUsed.Name = "lblFormulaUsed";
            this.lblFormulaUsed.Size = new System.Drawing.Size(93, 13);
            this.lblFormulaUsed.TabIndex = 9;
            this.lblFormulaUsed.Text = "Использована:";
            // 
            // txtFormulaUsed
            // 
            this.txtFormulaUsed.BackColor = System.Drawing.SystemColors.Info;
            this.txtFormulaUsed.Location = new System.Drawing.Point(250, 277);
            this.txtFormulaUsed.Name = "txtFormulaUsed";
            this.txtFormulaUsed.ReadOnly = true;
            this.txtFormulaUsed.Size = new System.Drawing.Size(350, 20);
            this.txtFormulaUsed.TabIndex = 10;
            // 
            // lblFxValue
            // 
            this.lblFxValue.AutoSize = true;
            this.lblFxValue.Location = new System.Drawing.Point(150, 320);
            this.lblFxValue.Name = "lblFxValue";
            this.lblFxValue.Size = new System.Drawing.Size(83, 13);
            this.lblFxValue.TabIndex = 11;
            this.lblFxValue.Text = "Значение f(x):";
            // 
            // txtFxValue
            // 
            this.txtFxValue.BackColor = System.Drawing.SystemColors.Info;
            this.txtFxValue.Location = new System.Drawing.Point(250, 317);
            this.txtFxValue.Name = "txtFxValue";
            this.txtFxValue.ReadOnly = true;
            this.txtFxValue.Size = new System.Drawing.Size(200, 20);
            this.txtFxValue.TabIndex = 12;
            // 
            // btnCalculateBranch
            // 
            this.btnCalculateBranch.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculateBranch.Location = new System.Drawing.Point(200, 370);
            this.btnCalculateBranch.Name = "btnCalculateBranch";
            this.btnCalculateBranch.Size = new System.Drawing.Size(100, 30);
            this.btnCalculateBranch.TabIndex = 13;
            this.btnCalculateBranch.Text = "Вычислить";
            this.btnCalculateBranch.UseVisualStyleBackColor = false;
            this.btnCalculateBranch.Click += new System.EventHandler(this.btnCalculateBranch_Click);
            // 
            // btnClearBranch
            // 
            this.btnClearBranch.Location = new System.Drawing.Point(320, 370);
            this.btnClearBranch.Name = "btnClearBranch";
            this.btnClearBranch.Size = new System.Drawing.Size(100, 30);
            this.btnClearBranch.TabIndex = 14;
            this.btnClearBranch.Text = "Очистить";
            this.btnClearBranch.UseVisualStyleBackColor = true;
            this.btnClearBranch.Click += new System.EventHandler(this.btnClearBranch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №5 - Ручная отладка ПО";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLinear.ResumeLayout(false);
            this.tabPageLinear.PerformLayout();
            this.tabPageBranch.ResumeLayout(false);
            this.tabPageBranch.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLinear;
        private System.Windows.Forms.TextBox txtIntermediate;
        private System.Windows.Forms.Label lblIntermediate;
        private System.Windows.Forms.Button btnClearLinear;
        private System.Windows.Forms.Button btnCalculateLinear;
        private System.Windows.Forms.TextBox txtResult_Linear;
        private System.Windows.Forms.Label lblResult_Linear;
        private System.Windows.Forms.TextBox txtZ_Linear;
        private System.Windows.Forms.Label lblZ_Linear;
        private System.Windows.Forms.TextBox txtY_Linear;
        private System.Windows.Forms.TextBox txtX_Linear;
        private System.Windows.Forms.Label lblY_Linear;
        private System.Windows.Forms.Label lblX_Linear;
        private System.Windows.Forms.Label lblTitle_Linear;
        private System.Windows.Forms.TabPage tabPageBranch;
        private System.Windows.Forms.Button btnClearBranch;
        private System.Windows.Forms.Button btnCalculateBranch;
        private System.Windows.Forms.TextBox txtFxValue;
        private System.Windows.Forms.Label lblFxValue;
        private System.Windows.Forms.TextBox txtFormulaUsed;
        private System.Windows.Forms.Label lblFormulaUsed;
        private System.Windows.Forms.TextBox txtResult_Branch;
        private System.Windows.Forms.Label lblResult_Branch;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.TextBox txtY_Branch;
        private System.Windows.Forms.TextBox txtX_Branch;
        private System.Windows.Forms.Label lblY_Branch;
        private System.Windows.Forms.Label lblX_Branch;
        private System.Windows.Forms.Label lblTitle_Branch;
    }
}