
namespace TRBD
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.dBSHOPDataSet1 = new TRBD.DBSHOPDataSet1();
            this.listProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listProductsTableAdapter = new TRBD.DBSHOPDataSet1TableAdapters.ListProductsTableAdapter();
            this.tableAdapterManager = new TRBD.DBSHOPDataSet1TableAdapters.TableAdapterManager();
            this.listProductsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listProductsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.NameCustomer = new System.Windows.Forms.TextBox();
            this.MiddleNameCustomer = new System.Windows.Forms.TextBox();
            this.LastNameCustomer = new System.Windows.Forms.TextBox();
            this.AddresCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MakeOrder = new System.Windows.Forms.Button();
            this.CodProdut = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingNavigator)).BeginInit();
            this.listProductsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBSHOPDataSet1
            // 
            this.dBSHOPDataSet1.DataSetName = "DBSHOPDataSet1";
            this.dBSHOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listProductsBindingSource
            // 
            this.listProductsBindingSource.DataMember = "ListProducts";
            this.listProductsBindingSource.DataSource = this.dBSHOPDataSet1;
            // 
            // listProductsTableAdapter
            // 
            this.listProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminWorkerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.OrderInShopTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRBD.DBSHOPDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerInKompanyTableAdapter = null;
            // 
            // listProductsBindingNavigator
            // 
            this.listProductsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listProductsBindingNavigator.BindingSource = this.listProductsBindingSource;
            this.listProductsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listProductsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listProductsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listProductsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listProductsBindingNavigatorSaveItem});
            this.listProductsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listProductsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listProductsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listProductsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listProductsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listProductsBindingNavigator.Name = "listProductsBindingNavigator";
            this.listProductsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listProductsBindingNavigator.Size = new System.Drawing.Size(1101, 31);
            this.listProductsBindingNavigator.TabIndex = 0;
            this.listProductsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // listProductsBindingNavigatorSaveItem
            // 
            this.listProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listProductsBindingNavigatorSaveItem.Enabled = false;
            this.listProductsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listProductsBindingNavigatorSaveItem.Image")));
            this.listProductsBindingNavigatorSaveItem.Name = "listProductsBindingNavigatorSaveItem";
            this.listProductsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.listProductsBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // listProductsDataGridView
            // 
            this.listProductsDataGridView.AllowUserToAddRows = false;
            this.listProductsDataGridView.AllowUserToDeleteRows = false;
            this.listProductsDataGridView.AutoGenerateColumns = false;
            this.listProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.listProductsDataGridView.DataSource = this.listProductsBindingSource;
            this.listProductsDataGridView.Location = new System.Drawing.Point(0, 55);
            this.listProductsDataGridView.Name = "listProductsDataGridView";
            this.listProductsDataGridView.ReadOnly = true;
            this.listProductsDataGridView.RowHeadersWidth = 51;
            this.listProductsDataGridView.RowTemplate.Height = 24;
            this.listProductsDataGridView.Size = new System.Drawing.Size(1101, 220);
            this.listProductsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код продукта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код продукта";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Категория продукта";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория продукта";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Тип Продукта";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип Продукта";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Материал";
            this.dataGridViewTextBoxColumn4.HeaderText = "Материал";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Цвет";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(856, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Чтобы сделать заказ, введите номер продукта и данные о себе";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameCustomer
            // 
            this.NameCustomer.Location = new System.Drawing.Point(164, 315);
            this.NameCustomer.Name = "NameCustomer";
            this.NameCustomer.Size = new System.Drawing.Size(314, 22);
            this.NameCustomer.TabIndex = 3;
            this.NameCustomer.TextChanged += new System.EventHandler(this.NameCustomer_TextChanged);
            // 
            // MiddleNameCustomer
            // 
            this.MiddleNameCustomer.Location = new System.Drawing.Point(164, 343);
            this.MiddleNameCustomer.Name = "MiddleNameCustomer";
            this.MiddleNameCustomer.Size = new System.Drawing.Size(314, 22);
            this.MiddleNameCustomer.TabIndex = 4;
            // 
            // LastNameCustomer
            // 
            this.LastNameCustomer.Location = new System.Drawing.Point(164, 371);
            this.LastNameCustomer.Name = "LastNameCustomer";
            this.LastNameCustomer.Size = new System.Drawing.Size(314, 22);
            this.LastNameCustomer.TabIndex = 5;
            // 
            // AddresCustomer
            // 
            this.AddresCustomer.Location = new System.Drawing.Point(164, 400);
            this.AddresCustomer.Name = "AddresCustomer";
            this.AddresCustomer.Size = new System.Drawing.Size(314, 22);
            this.AddresCustomer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Адрес доставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Код продукта";
            // 
            // MakeOrder
            // 
            this.MakeOrder.BackColor = System.Drawing.SystemColors.Info;
            this.MakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MakeOrder.Location = new System.Drawing.Point(627, 330);
            this.MakeOrder.Name = "MakeOrder";
            this.MakeOrder.Size = new System.Drawing.Size(242, 106);
            this.MakeOrder.TabIndex = 13;
            this.MakeOrder.Text = "Сделать заказ";
            this.MakeOrder.UseVisualStyleBackColor = false;
            this.MakeOrder.Click += new System.EventHandler(this.MakeOrder_Click);
            // 
            // CodProdut
            // 
            this.CodProdut.DataSource = this.listProductsBindingSource;
            this.CodProdut.DisplayMember = "Код продукта";
            this.CodProdut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodProdut.FormattingEnabled = true;
            this.CodProdut.Location = new System.Drawing.Point(164, 429);
            this.CodProdut.Name = "CodProdut";
            this.CodProdut.Size = new System.Drawing.Size(314, 24);
            this.CodProdut.TabIndex = 14;
            this.CodProdut.ValueMember = "Код продукта";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(0, 26);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(97, 23);
            this.Back.TabIndex = 15;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 586);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CodProdut);
            this.Controls.Add(this.MakeOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddresCustomer);
            this.Controls.Add(this.LastNameCustomer);
            this.Controls.Add(this.MiddleNameCustomer);
            this.Controls.Add(this.NameCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProductsDataGridView);
            this.Controls.Add(this.listProductsBindingNavigator);
            this.Name = "FormCustomer";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingNavigator)).EndInit();
            this.listProductsBindingNavigator.ResumeLayout(false);
            this.listProductsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBSHOPDataSet1 dBSHOPDataSet1;
        private System.Windows.Forms.BindingSource listProductsBindingSource;
        private DBSHOPDataSet1TableAdapters.ListProductsTableAdapter listProductsTableAdapter;
        private DBSHOPDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator listProductsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listProductsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView listProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameCustomer;
        private System.Windows.Forms.TextBox MiddleNameCustomer;
        private System.Windows.Forms.TextBox LastNameCustomer;
        private System.Windows.Forms.TextBox AddresCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MakeOrder;
        private System.Windows.Forms.ComboBox CodProdut;
        private System.Windows.Forms.Button Back;
    }
}