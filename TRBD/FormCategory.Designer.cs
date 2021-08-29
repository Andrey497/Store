
namespace TRBD
{
    partial class FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            this.dBSHOPDataSet1 = new TRBD.DBSHOPDataSet1();
            this.listCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCategoryTableAdapter = new TRBD.DBSHOPDataSet1TableAdapters.ListCategoryTableAdapter();
            this.tableAdapterManager = new TRBD.DBSHOPDataSet1TableAdapters.TableAdapterManager();
            this.listCategoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listCategoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryBindingNavigator)).BeginInit();
            this.listCategoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBSHOPDataSet1
            // 
            this.dBSHOPDataSet1.DataSetName = "DBSHOPDataSet1";
            this.dBSHOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listCategoryBindingSource
            // 
            this.listCategoryBindingSource.DataMember = "ListCategory";
            this.listCategoryBindingSource.DataSource = this.dBSHOPDataSet1;
            // 
            // listCategoryTableAdapter
            // 
            this.listCategoryTableAdapter.ClearBeforeFill = true;
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
            // listCategoryBindingNavigator
            // 
            this.listCategoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listCategoryBindingNavigator.BindingSource = this.listCategoryBindingSource;
            this.listCategoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listCategoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listCategoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listCategoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listCategoryBindingNavigatorSaveItem});
            this.listCategoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listCategoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listCategoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listCategoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listCategoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listCategoryBindingNavigator.Name = "listCategoryBindingNavigator";
            this.listCategoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listCategoryBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.listCategoryBindingNavigator.TabIndex = 0;
            this.listCategoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // listCategoryBindingNavigatorSaveItem
            // 
            this.listCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listCategoryBindingNavigatorSaveItem.Enabled = false;
            this.listCategoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listCategoryBindingNavigatorSaveItem.Image")));
            this.listCategoryBindingNavigatorSaveItem.Name = "listCategoryBindingNavigatorSaveItem";
            this.listCategoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.listCategoryBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // listCategoryDataGridView
            // 
            this.listCategoryDataGridView.AllowUserToAddRows = false;
            this.listCategoryDataGridView.AllowUserToDeleteRows = false;
            this.listCategoryDataGridView.AutoGenerateColumns = false;
            this.listCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.listCategoryDataGridView.DataSource = this.listCategoryBindingSource;
            this.listCategoryDataGridView.Location = new System.Drawing.Point(81, 30);
            this.listCategoryDataGridView.Name = "listCategoryDataGridView";
            this.listCategoryDataGridView.ReadOnly = true;
            this.listCategoryDataGridView.RowHeadersWidth = 51;
            this.listCategoryDataGridView.RowTemplate.Height = 24;
            this.listCategoryDataGridView.Size = new System.Drawing.Size(707, 220);
            this.listCategoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код отдела";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код отдела";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название отдела";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название отдела";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название Отдела";
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCategory.Location = new System.Drawing.Point(58, 336);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(112, 37);
            this.buttonDeleteCategory.TabIndex = 4;
            this.buttonDeleteCategory.Text = "Удалить";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCategory.Location = new System.Drawing.Point(205, 336);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(112, 37);
            this.buttonAddCategory.TabIndex = 5;
            this.buttonAddCategory.Text = "Добавить";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 6;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(0, 30);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(81, 37);
            this.back.TabIndex = 31;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCategoryDataGridView);
            this.Controls.Add(this.listCategoryBindingNavigator);
            this.Name = "FormCategory";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryBindingNavigator)).EndInit();
            this.listCategoryBindingNavigator.ResumeLayout(false);
            this.listCategoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBSHOPDataSet1 dBSHOPDataSet1;
        private System.Windows.Forms.BindingSource listCategoryBindingSource;
        private DBSHOPDataSet1TableAdapters.ListCategoryTableAdapter listCategoryTableAdapter;
        private DBSHOPDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator listCategoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listCategoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView listCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button back;
    }
}