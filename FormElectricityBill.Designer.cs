
namespace Assingment_01
{
    partial class FormElectricityBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormElectricityBill));
            this.buttonCheckBill = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumberofUnits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxInputdata = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheckBill
            // 
            this.buttonCheckBill.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCheckBill.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckBill.Location = new System.Drawing.Point(309, 182);
            this.buttonCheckBill.Name = "buttonCheckBill";
            this.buttonCheckBill.Size = new System.Drawing.Size(176, 34);
            this.buttonCheckBill.TabIndex = 6;
            this.buttonCheckBill.Text = "Check monthly bill";
            this.buttonCheckBill.UseVisualStyleBackColor = false;
            this.buttonCheckBill.Click += new System.EventHandler(this.buttonCheckBill_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of units";
            // 
            // textBoxNumberofUnits
            // 
            this.textBoxNumberofUnits.Location = new System.Drawing.Point(253, 268);
            this.textBoxNumberofUnits.Name = "textBoxNumberofUnits";
            this.textBoxNumberofUnits.Size = new System.Drawing.Size(232, 20);
            this.textBoxNumberofUnits.TabIndex = 8;
            this.textBoxNumberofUnits.TextChanged += new System.EventHandler(this.textBoxNumberofUnits_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(253, 323);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(232, 20);
            this.textBoxAmount.TabIndex = 10;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // textBoxInputdata
            // 
            this.textBoxInputdata.Location = new System.Drawing.Point(253, 131);
            this.textBoxInputdata.Name = "textBoxInputdata";
            this.textBoxInputdata.Size = new System.Drawing.Size(232, 20);
            this.textBoxInputdata.TabIndex = 11;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(253, 71);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(232, 20);
            this.textBoxMonth.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Units";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name of Month";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormElectricityBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxInputdata);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumberofUnits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCheckBill);
            this.Name = "FormElectricityBill";
            this.Text = "FormElectricityBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCheckBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumberofUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxInputdata;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}