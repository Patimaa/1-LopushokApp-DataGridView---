
namespace LopushokApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.SortCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.DownCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltrCombo = new System.Windows.Forms.ComboBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CostChangeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортировка";
            // 
            // SortCombo
            // 
            this.SortCombo.FormattingEnabled = true;
            this.SortCombo.Items.AddRange(new object[] {
            "Без сортировки",
            "Наименование",
            "Номер цеха",
            "Мин.стоимость"});
            this.SortCombo.Location = new System.Drawing.Point(16, 21);
            this.SortCombo.Name = "SortCombo";
            this.SortCombo.Size = new System.Drawing.Size(138, 21);
            this.SortCombo.TabIndex = 4;
            this.SortCombo.SelectedIndexChanged += new System.EventHandler(this.SortCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(262, 21);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(139, 20);
            this.SearchTxt.TabIndex = 5;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // DownCheck
            // 
            this.DownCheck.AutoSize = true;
            this.DownCheck.Location = new System.Drawing.Point(162, 24);
            this.DownCheck.Name = "DownCheck";
            this.DownCheck.Size = new System.Drawing.Size(75, 17);
            this.DownCheck.TabIndex = 6;
            this.DownCheck.Text = "убывание";
            this.DownCheck.UseVisualStyleBackColor = true;
            this.DownCheck.CheckedChanged += new System.EventHandler(this.DownCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фильтрация";
            // 
            // FiltrCombo
            // 
            this.FiltrCombo.FormattingEnabled = true;
            this.FiltrCombo.Items.AddRange(new object[] {
            "Все типы"});
            this.FiltrCombo.Location = new System.Drawing.Point(449, 21);
            this.FiltrCombo.Name = "FiltrCombo";
            this.FiltrCombo.Size = new System.Drawing.Size(157, 21);
            this.FiltrCombo.TabIndex = 4;
            this.FiltrCombo.SelectedIndexChanged += new System.EventHandler(this.FiltrCombo_SelectedIndexChanged);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(16, 432);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(152, 23);
            this.AddProductBtn.TabIndex = 9;
            this.AddProductBtn.Text = "Добавить товар";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Location = new System.Drawing.Point(183, 432);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(152, 23);
            this.EditProductBtn.TabIndex = 9;
            this.EditProductBtn.Text = "Редактировать товар";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(350, 432);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(152, 23);
            this.deleteProduct.TabIndex = 9;
            this.deleteProduct.Text = "Удалить товар";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(16, 55);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(851, 359);
            this.productDataGridView.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductTypeID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип Продукции";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ArticleNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProductionPersonCount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Кол-во работников";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductionWorkshopNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер Цеха";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MinCostForAgent";
            this.dataGridViewTextBoxColumn9.HeaderText = "Мин.Стоимость";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LopushokApp.ModelEF.Product);
            // 
            // CostChangeBtn
            // 
            this.CostChangeBtn.Location = new System.Drawing.Point(552, 432);
            this.CostChangeBtn.Name = "CostChangeBtn";
            this.CostChangeBtn.Size = new System.Drawing.Size(152, 23);
            this.CostChangeBtn.TabIndex = 8;
            this.CostChangeBtn.Text = "Изменить стоимость на ...";
            this.CostChangeBtn.UseVisualStyleBackColor = true;
            this.CostChangeBtn.Click += new System.EventHandler(this.CostChangeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 467);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.CostChangeBtn);
            this.Controls.Add(this.DownCheck);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.FiltrCombo);
            this.Controls.Add(this.SortCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Информационная система \"Лопушок\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SortCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.CheckBox DownCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FiltrCombo;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button CostChangeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

