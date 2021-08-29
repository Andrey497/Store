
namespace TRBD
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.dBSHOPDataSet1 = new TRBD.DBSHOPDataSet1();
            this.lISTORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lISTORDERTableAdapter = new TRBD.DBSHOPDataSet1TableAdapters.LISTORDERTableAdapter();
            this.tableAdapterManager = new TRBD.DBSHOPDataSet1TableAdapters.TableAdapterManager();
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
            this.lISTORDERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBSHOPDataSet2 = new TRBD.DBSHOPDataSet2();
            this.listDriverOpenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listDriverOpenTableAdapter = new TRBD.DBSHOPDataSet2TableAdapters.ListDriverOpenTableAdapter();
            this.tableAdapterManager1 = new TRBD.DBSHOPDataSet2TableAdapters.TableAdapterManager();
            this.listDriverOpenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeOrder = new System.Windows.Forms.TextBox();
            this.CodeDriver = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReadyDriver = new System.Windows.Forms.Button();
            this.buttonGoDevillery = new System.Windows.Forms.Button();
            this.buttonFinnishDevillery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERBindingNavigator)).BeginInit();
            this.lISTORDERBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDriverOpenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDriverOpenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBSHOPDataSet1
            // 
            this.dBSHOPDataSet1.DataSetName = "DBSHOPDataSet1";
            this.dBSHOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lISTORDERBindingSource
            // 
            this.lISTORDERBindingSource.DataMember = "LISTORDER";
            this.lISTORDERBindingSource.DataSource = this.dBSHOPDataSet1;
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
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.OrderInShopTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRBD.DBSHOPDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerInKompanyTableAdapter = null;
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
            this.lISTORDERBindingNavigator.Size = new System.Drawing.Size(1924, 27);
            this.lISTORDERBindingNavigator.TabIndex = 0;
            this.lISTORDERBindingNavigator.Text = "bindingNavigator1";
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
            // lISTORDERBindingNavigatorSaveItem
            // 
            this.lISTORDERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lISTORDERBindingNavigatorSaveItem.Enabled = false;
            this.lISTORDERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lISTORDERBindingNavigatorSaveItem.Image")));
            this.lISTORDERBindingNavigatorSaveItem.Name = "lISTORDERBindingNavigatorSaveItem";
            this.lISTORDERBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.lISTORDERBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // lISTORDERDataGridView
            // 
            this.lISTORDERDataGridView.AutoGenerateColumns = false;
            this.lISTORDERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lISTORDERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.lISTORDERDataGridView.DataSource = this.lISTORDERBindingSource;
            this.lISTORDERDataGridView.Location = new System.Drawing.Point(0, 31);
            this.lISTORDERDataGridView.Name = "lISTORDERDataGridView";
            this.lISTORDERDataGridView.RowHeadersWidth = 51;
            this.lISTORDERDataGridView.RowTemplate.Height = 24;
            this.lISTORDERDataGridView.Size = new System.Drawing.Size(1924, 220);
            this.lISTORDERDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код заказа";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код заказа";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код товара";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код товара";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя заказчика";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя заказчика";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество заказчика";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество заказчика";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Фамилия заказчика";
            this.dataGridViewTextBoxColumn5.HeaderText = "Фамилия заказчика";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Адрес доставки";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес доставки";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "код водителя";
            this.dataGridViewTextBoxColumn7.HeaderText = "код водителя";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Имя водителя";
            this.dataGridViewTextBoxColumn8.HeaderText = "Имя водителя";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Отчество водителя";
            this.dataGridViewTextBoxColumn9.HeaderText = "Отчество водителя";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Фамилия водителя";
            this.dataGridViewTextBoxColumn10.HeaderText = "Фамилия водителя";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Статус заказа";
            this.dataGridViewTextBoxColumn11.HeaderText = "Статус заказа";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dBSHOPDataSet2
            // 
            this.dBSHOPDataSet2.DataSetName = "DBSHOPDataSet2";
            this.dBSHOPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listDriverOpenBindingSource
            // 
            this.listDriverOpenBindingSource.DataMember = "ListDriverOpen";
            this.listDriverOpenBindingSource.DataSource = this.dBSHOPDataSet2;
            // 
            // listDriverOpenTableAdapter
            // 
            this.listDriverOpenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = TRBD.DBSHOPDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listDriverOpenDataGridView
            // 
            this.listDriverOpenDataGridView.AutoGenerateColumns = false;
            this.listDriverOpenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDriverOpenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.listDriverOpenDataGridView.DataSource = this.listDriverOpenBindingSource;
            this.listDriverOpenDataGridView.Location = new System.Drawing.Point(0, 288);
            this.listDriverOpenDataGridView.Name = "listDriverOpenDataGridView";
            this.listDriverOpenDataGridView.RowHeadersWidth = 51;
            this.listDriverOpenDataGridView.RowTemplate.Height = 24;
            this.listDriverOpenDataGridView.Size = new System.Drawing.Size(680, 220);
            this.listDriverOpenDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Код водителя";
            this.dataGridViewTextBoxColumn12.HeaderText = "Код водителя";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Имя водителя";
            this.dataGridViewTextBoxColumn13.HeaderText = "Имя водителя";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Отчество водителя";
            this.dataGridViewTextBoxColumn14.HeaderText = "Отчество водителя";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Фамилия водителя";
            this.dataGridViewTextBoxColumn15.HeaderText = "Фамилия водителя";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список свободных водителей";
            // 
            // CodeOrder
            // 
            this.CodeOrder.Location = new System.Drawing.Point(790, 314);
            this.CodeOrder.Name = "CodeOrder";
            this.CodeOrder.Size = new System.Drawing.Size(166, 22);
            this.CodeOrder.TabIndex = 4;
            // 
            // CodeDriver
            // 
            this.CodeDriver.DataSource = this.listDriverOpenBindingSource;
            this.CodeDriver.DisplayMember = "Код водителя";
            this.CodeDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodeDriver.FormattingEnabled = true;
            this.CodeDriver.Location = new System.Drawing.Point(1007, 314);
            this.CodeDriver.Name = "CodeDriver";
            this.CodeDriver.Size = new System.Drawing.Size(174, 24);
            this.CodeDriver.TabIndex = 5;
            this.CodeDriver.ValueMember = "Код водителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1048, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Код водителя";
            // 
            // buttonReadyDriver
            // 
            this.buttonReadyDriver.Location = new System.Drawing.Point(686, 449);
            this.buttonReadyDriver.Name = "buttonReadyDriver";
            this.buttonReadyDriver.Size = new System.Drawing.Size(202, 59);
            this.buttonReadyDriver.TabIndex = 9;
            this.buttonReadyDriver.Text = "Поменять статус заказа на готов к отправки";
            this.buttonReadyDriver.UseVisualStyleBackColor = true;
            this.buttonReadyDriver.Click += new System.EventHandler(this.buttonReadyDriver_Click);
            // 
            // buttonGoDevillery
            // 
            this.buttonGoDevillery.Location = new System.Drawing.Point(894, 449);
            this.buttonGoDevillery.Name = "buttonGoDevillery";
            this.buttonGoDevillery.Size = new System.Drawing.Size(202, 59);
            this.buttonGoDevillery.TabIndex = 10;
            this.buttonGoDevillery.Text = "Поменять статус заказа на в пути и назначить водителя";
            this.buttonGoDevillery.UseVisualStyleBackColor = true;
            this.buttonGoDevillery.Click += new System.EventHandler(this.buttonGoDevillery_Click);
            // 
            // buttonFinnishDevillery
            // 
            this.buttonFinnishDevillery.Location = new System.Drawing.Point(1102, 449);
            this.buttonFinnishDevillery.Name = "buttonFinnishDevillery";
            this.buttonFinnishDevillery.Size = new System.Drawing.Size(202, 59);
            this.buttonFinnishDevillery.TabIndex = 11;
            this.buttonFinnishDevillery.Text = "Поменять статус заказа на доставлено";
            this.buttonFinnishDevillery.UseVisualStyleBackColor = true;
            this.buttonFinnishDevillery.Click += new System.EventHandler(this.buttonFinnishDevillery_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 522);
            this.Controls.Add(this.buttonFinnishDevillery);
            this.Controls.Add(this.buttonGoDevillery);
            this.Controls.Add(this.buttonReadyDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodeDriver);
            this.Controls.Add(this.CodeOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDriverOpenDataGridView);
            this.Controls.Add(this.lISTORDERDataGridView);
            this.Controls.Add(this.lISTORDERBindingNavigator);
            this.Name = "FormOrders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERBindingNavigator)).EndInit();
            this.lISTORDERBindingNavigator.ResumeLayout(false);
            this.lISTORDERBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lISTORDERDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSHOPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDriverOpenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDriverOpenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBSHOPDataSet1 dBSHOPDataSet1;
        private System.Windows.Forms.BindingSource lISTORDERBindingSource;
        private DBSHOPDataSet1TableAdapters.LISTORDERTableAdapter lISTORDERTableAdapter;
        private DBSHOPDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView lISTORDERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DBSHOPDataSet2 dBSHOPDataSet2;
        private System.Windows.Forms.BindingSource listDriverOpenBindingSource;
        private DBSHOPDataSet2TableAdapters.ListDriverOpenTableAdapter listDriverOpenTableAdapter;
        private DBSHOPDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView listDriverOpenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeOrder;
        private System.Windows.Forms.ComboBox CodeDriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReadyDriver;
        private System.Windows.Forms.Button buttonGoDevillery;
        private System.Windows.Forms.Button buttonFinnishDevillery;
    }
}