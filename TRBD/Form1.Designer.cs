namespace TRBD
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
            this.dBSHOPDataSet = new TRBD.DBSHOPDataSet();
            this.lISTORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lISTORDERTableAdapter = new TRBD.DBSHOPDataSetTableAdapters.LISTORDERTableAdapter();
            this.tableAdapterManager = new TRBD.DBSHOPDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter = new TRBD.DBSHOPDataSetTableAdapters.CustomerTableAdapter();
            this.lISTORDERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lISTORDERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lISTWORKERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lISTWORKERTableAdapter = new TRBD.DBSHOPDataSetTableAdapters.LISTWORKERTableAdapter();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listProductsTableAdapter = new TRBD.DBSHOPDataSetTableAdapters.ListProductsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.userMenu = new System.Windows.Forms.Button();
            this.WorkerButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.IdOrder = new System.Windows.Forms.TextBox();
            this.StatusByIdOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERBindingNavigator)).BeginInit();
            this.lISTORDERBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lISTWORKERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dBSHOPDataSet
            // 
            this.dBSHOPDataSet.DataSetName = "DBSHOPDataSet";
            this.dBSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lISTORDERBindingSource
            // 
            this.lISTORDERBindingSource.DataMember = "LISTORDER";
            this.lISTORDERBindingSource.DataSource = this.dBSHOPDataSet;
            // 
            // lISTORDERTableAdapter
            // 
            this.lISTORDERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminWorkerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.historyTableAdapter = null;
            this.tableAdapterManager.OrderInShopTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRBD.DBSHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerInKompanyTableAdapter = null;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // lISTORDERBindingNavigator
            // 
            this.lISTORDERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lISTORDERBindingNavigator.BindingSource = this.lISTORDERBindingSource;
            this.lISTORDERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lISTORDERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lISTORDERBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lISTORDERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lISTORDERBindingNavigatorSaveItem});
            this.lISTORDERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lISTORDERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lISTORDERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lISTORDERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lISTORDERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lISTORDERBindingNavigator.Name = "lISTORDERBindingNavigator";
            this.lISTORDERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lISTORDERBindingNavigator.Size = new System.Drawing.Size(1100, 31);
            this.lISTORDERBindingNavigator.TabIndex = 0;
            this.lISTORDERBindingNavigator.Text = "bindingNavigator1";
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
            // lISTORDERBindingNavigatorSaveItem
            // 
            this.lISTORDERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lISTORDERBindingNavigatorSaveItem.Enabled = false;
            this.lISTORDERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lISTORDERBindingNavigatorSaveItem.Image")));
            this.lISTORDERBindingNavigatorSaveItem.Name = "lISTORDERBindingNavigatorSaveItem";
            this.lISTORDERBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.lISTORDERBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // lISTWORKERBindingSource
            // 
            this.lISTWORKERBindingSource.DataMember = "LISTWORKER";
            this.lISTWORKERBindingSource.DataSource = this.dBSHOPDataSet;
            // 
            // lISTWORKERTableAdapter
            // 
            this.lISTWORKERTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dBSHOPDataSet;
            // 
            // listProductsBindingSource
            // 
            this.listProductsBindingSource.DataMember = "ListProducts";
            this.listProductsBindingSource.DataSource = this.dBSHOPDataSet;
            // 
            // listProductsTableAdapter
            // 
            this.listProductsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(864, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "Приветствуем вас в нашем магазинея,\r\nнадеюсь вам понравится что-нибудь из наших т" +
    "оваров";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userMenu
            // 
            this.userMenu.Location = new System.Drawing.Point(350, 175);
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(400, 111);
            this.userMenu.TabIndex = 4;
            this.userMenu.Text = "Заказ Мебели";
            this.userMenu.UseVisualStyleBackColor = true;
            this.userMenu.Click += new System.EventHandler(this.userMenu_Click);
            // 
            // WorkerButton
            // 
            this.WorkerButton.Location = new System.Drawing.Point(953, 425);
            this.WorkerButton.Name = "WorkerButton";
            this.WorkerButton.Size = new System.Drawing.Size(147, 35);
            this.WorkerButton.TabIndex = 5;
            this.WorkerButton.Text = "Для рабтников";
            this.WorkerButton.UseVisualStyleBackColor = true;
            this.WorkerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // IdOrder
            // 
            this.IdOrder.Location = new System.Drawing.Point(23, 354);
            this.IdOrder.Name = "IdOrder";
            this.IdOrder.Size = new System.Drawing.Size(205, 22);
            this.IdOrder.TabIndex = 6;
            // 
            // StatusByIdOrder
            // 
            this.StatusByIdOrder.Location = new System.Drawing.Point(23, 383);
            this.StatusByIdOrder.Name = "StatusByIdOrder";
            this.StatusByIdOrder.Size = new System.Drawing.Size(205, 50);
            this.StatusByIdOrder.TabIndex = 7;
            this.StatusByIdOrder.Text = "Узнать  статус заказа";
            this.StatusByIdOrder.UseVisualStyleBackColor = true;
            this.StatusByIdOrder.Click += new System.EventHandler(this.StatusByIdOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер заказа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusByIdOrder);
            this.Controls.Add(this.IdOrder);
            this.Controls.Add(this.WorkerButton);
            this.Controls.Add(this.userMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lISTORDERBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERBindingNavigator)).EndInit();
            this.lISTORDERBindingNavigator.ResumeLayout(false);
            this.lISTORDERBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lISTWORKERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBSHOPDataSet dBSHOPDataSet;
        private System.Windows.Forms.BindingSource lISTORDERBindingSource;
        private DBSHOPDataSetTableAdapters.LISTORDERTableAdapter lISTORDERTableAdapter;
        private DBSHOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lISTORDERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lISTORDERBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource lISTWORKERBindingSource;
        private DBSHOPDataSetTableAdapters.LISTWORKERTableAdapter lISTWORKERTableAdapter;
        private DBSHOPDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource listProductsBindingSource;
        private DBSHOPDataSetTableAdapters.ListProductsTableAdapter listProductsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userMenu;
        private System.Windows.Forms.Button WorkerButton;
        private System.Windows.Forms.TextBox IdOrder;
        private System.Windows.Forms.Button StatusByIdOrder;
        private System.Windows.Forms.Label label2;
    }
}

