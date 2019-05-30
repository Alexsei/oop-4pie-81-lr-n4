namespace ООП_4ПИЭ_81_ЛР_N4_Вопиловский
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listStoreView = new System.Windows.Forms.ListView();
            this.sId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sProducer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sMarkup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sMarkup2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listStoreView
            // 
            this.listStoreView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sId,
            this.sName,
            this.sProducer,
            this.sCategory,
            this.sPrice,
            this.year,
            this.bPrice,
            this.sMarkup,
            this.sMarkup2});
            this.listStoreView.Location = new System.Drawing.Point(5, 38);
            this.listStoreView.Name = "listStoreView";
            this.listStoreView.Size = new System.Drawing.Size(683, 211);
            this.listStoreView.TabIndex = 1;
            this.listStoreView.UseCompatibleStateImageBehavior = false;
            this.listStoreView.View = System.Windows.Forms.View.Details;
            // 
            // sId
            // 
            this.sId.Tag = "";
            this.sId.Text = "№";
            this.sId.Width = 35;
            // 
            // sName
            // 
            this.sName.Text = "Название";
            this.sName.Width = 130;
            // 
            // sProducer
            // 
            this.sProducer.Text = "Производитель";
            this.sProducer.Width = 94;
            // 
            // sCategory
            // 
            this.sCategory.Text = "Кат.";
            this.sCategory.Width = 35;
            // 
            // sPrice
            // 
            this.sPrice.Text = "Цена";
            this.sPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sPrice.Width = 80;
            // 
            // sMarkup
            // 
            this.sMarkup.Text = "Баз.Наценка";
            this.sMarkup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sMarkup.Width = 86;
            // 
            // sMarkup2
            // 
            this.sMarkup2.Text = "Нац. тек. год";
            this.sMarkup2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sMarkup2.Width = 87;
            // 
            // year
            // 
            this.year.Text = "Год ";
            this.year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year.Width = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBox1.Location = new System.Drawing.Point(94, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "2019";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.ComboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбрать год";
            // 
            // bPrice
            // 
            this.bPrice.Text = "баз.Цена";
            this.bPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listStoreView);
            this.Name = "Form1";
            this.Text = "ООП 4ПИЭ-81 ЛР N4 Вопиловский";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listStoreView;
        private System.Windows.Forms.ColumnHeader sId;
        private System.Windows.Forms.ColumnHeader sName;
        private System.Windows.Forms.ColumnHeader sProducer;
        private System.Windows.Forms.ColumnHeader sCategory;
        private System.Windows.Forms.ColumnHeader sPrice;
        private System.Windows.Forms.ColumnHeader sMarkup;
        private System.Windows.Forms.ColumnHeader sMarkup2;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader bPrice;
    }
}

