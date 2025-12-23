namespace Shoes
{
    partial class FormGoodsOrOrder
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
            panel1 = new Panel();
            lblUserName = new Label();
            btnOut = new Button();
            dataGridView = new DataGridView();
            btnOrder = new Button();
            btnGoods = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(btnOut);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1009, 50);
            panel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.ForeColor = Color.FromArgb(64, 64, 64);
            lblUserName.Location = new Point(797, 10);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(52, 21);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnOut
            // 
            btnOut.BackColor = Color.MediumSpringGreen;
            btnOut.Dock = DockStyle.Right;
            btnOut.FlatAppearance.BorderSize = 0;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.ForeColor = Color.Black;
            btnOut.Location = new Point(849, 10);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(150, 30);
            btnOut.TabIndex = 6;
            btnOut.Text = "Выход";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(10, 60);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(1009, 560);
            dataGridView.TabIndex = 1;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.MediumSpringGreen;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.ForeColor = Color.Black;
            btnOrder.Location = new Point(253, 190);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(500, 50);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "Заказы";
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnGoods
            // 
            btnGoods.BackColor = Color.Chartreuse;
            btnGoods.FlatAppearance.BorderSize = 0;
            btnGoods.FlatStyle = FlatStyle.Flat;
            btnGoods.ForeColor = Color.Black;
            btnGoods.Location = new Point(253, 295);
            btnGoods.Name = "btnGoods";
            btnGoods.Size = new Size(500, 50);
            btnGoods.TabIndex = 9;
            btnGoods.Text = "Товары";
            btnGoods.UseVisualStyleBackColor = false;
            // 
            // FormGoodsOrOrder
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnGoods);
            Controls.Add(btnOrder);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGoodsOrOrder";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товары и заказы";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOut;
        private Label lblUserName;
        private DataGridView dataGridView;
        private Button btnOrder;
        private Button btnGoods;
    }
}