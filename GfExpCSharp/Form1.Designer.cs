namespace GfExpCSharp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InitialLv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetLv = new System.Windows.Forms.ComboBox();
            this.HasExp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Map = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpandTimes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BonusCheck = new System.Windows.Forms.CheckBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Lv100Progress = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.labelExpEachBattle = new System.Windows.Forms.Label();
            this.DecreaseLv = new System.Windows.Forms.Label();
            this.ExpEachBattle = new System.Windows.Forms.Label();
            this.LeaderTimes = new System.Windows.Forms.Label();
            this.NormalTimes = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LMTimes = new System.Windows.Forms.Label();
            this.MVPTimes = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BattleTimes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelTotalExp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ReadRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpEachx1 = new System.Windows.Forms.Label();
            this.labelEachx1 = new System.Windows.Forms.Label();
            this.ExpEveryTime = new System.Windows.Forms.Label();
            this.labelExpEveryTime = new System.Windows.Forms.Label();
            this.buttonHasExp = new System.Windows.Forms.Button();
            this.toolTipPrompt = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.labelNextLvTimes = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InitialLv
            // 
            this.InitialLv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.InitialLv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.InitialLv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialLv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InitialLv.FormattingEnabled = true;
            this.InitialLv.IntegralHeight = false;
            this.InitialLv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.InitialLv.Location = new System.Drawing.Point(150, 46);
            this.InitialLv.MaxDropDownItems = 5;
            this.InitialLv.Name = "InitialLv";
            this.InitialLv.Size = new System.Drawing.Size(121, 23);
            this.InitialLv.TabIndex = 0;
            this.InitialLv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "初始等级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "目标等级";
            // 
            // TargetLv
            // 
            this.TargetLv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TargetLv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TargetLv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetLv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TargetLv.FormattingEnabled = true;
            this.TargetLv.IntegralHeight = false;
            this.TargetLv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.TargetLv.Location = new System.Drawing.Point(150, 146);
            this.TargetLv.MaxDropDownItems = 5;
            this.TargetLv.Name = "TargetLv";
            this.TargetLv.Size = new System.Drawing.Size(121, 23);
            this.TargetLv.TabIndex = 3;
            // 
            // HasExp
            // 
            this.HasExp.BackColor = System.Drawing.SystemColors.Window;
            this.HasExp.Location = new System.Drawing.Point(150, 96);
            this.HasExp.Name = "HasExp";
            this.HasExp.Size = new System.Drawing.Size(121, 25);
            this.HasExp.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(50, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 104;
            this.label4.Text = "地图";
            // 
            // Map
            // 
            this.Map.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Map.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Map.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Map.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Map.FormattingEnabled = true;
            this.Map.IntegralHeight = false;
            this.Map.Items.AddRange(new object[] {
            "21E",
            "33E",
            "43E",
            "44E",
            "54",
            "54E"});
            this.Map.Location = new System.Drawing.Point(150, 196);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(121, 23);
            this.Map.TabIndex = 4;
            this.Map.SelectedIndexChanged += new System.EventHandler(this.Map_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(400, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 101;
            this.label5.Text = "扩编等级: x";
            // 
            // ExpandTimes
            // 
            this.ExpandTimes.DisplayMember = "1";
            this.ExpandTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpandTimes.FormattingEnabled = true;
            this.ExpandTimes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpandTimes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ExpandTimes.Location = new System.Drawing.Point(510, 50);
            this.ExpandTimes.Name = "ExpandTimes";
            this.ExpandTimes.Size = new System.Drawing.Size(50, 23);
            this.ExpandTimes.TabIndex = 1;
            this.ExpandTimes.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(425, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 105;
            this.label6.Text = "Bonus";
            // 
            // BonusCheck
            // 
            this.BonusCheck.AutoSize = true;
            this.BonusCheck.Location = new System.Drawing.Point(490, 202);
            this.BonusCheck.Name = "BonusCheck";
            this.BonusCheck.Size = new System.Drawing.Size(18, 17);
            this.BonusCheck.TabIndex = 5;
            this.BonusCheck.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CalculateButton.Location = new System.Drawing.Point(545, 181);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(122, 57);
            this.CalculateButton.TabIndex = 99;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Lv100Progress
            // 
            this.Lv100Progress.Location = new System.Drawing.Point(54, 272);
            this.Lv100Progress.Name = "Lv100Progress";
            this.Lv100Progress.Size = new System.Drawing.Size(613, 23);
            this.Lv100Progress.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(50, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 107;
            this.label7.Text = "衰减等级";
            // 
            // labelExpEachBattle
            // 
            this.labelExpEachBattle.AutoSize = true;
            this.labelExpEachBattle.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExpEachBattle.Location = new System.Drawing.Point(50, 425);
            this.labelExpEachBattle.Name = "labelExpEachBattle";
            this.labelExpEachBattle.Size = new System.Drawing.Size(85, 19);
            this.labelExpEachBattle.TabIndex = 108;
            this.labelExpEachBattle.Text = "每战经验";
            // 
            // DecreaseLv
            // 
            this.DecreaseLv.AutoSize = true;
            this.DecreaseLv.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DecreaseLv.Location = new System.Drawing.Point(172, 325);
            this.DecreaseLv.Name = "DecreaseLv";
            this.DecreaseLv.Size = new System.Drawing.Size(19, 19);
            this.DecreaseLv.TabIndex = 109;
            this.DecreaseLv.Text = "0";
            // 
            // ExpEachBattle
            // 
            this.ExpEachBattle.AutoSize = true;
            this.ExpEachBattle.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExpEachBattle.Location = new System.Drawing.Point(172, 425);
            this.ExpEachBattle.Name = "ExpEachBattle";
            this.ExpEachBattle.Size = new System.Drawing.Size(19, 19);
            this.ExpEachBattle.TabIndex = 110;
            this.ExpEachBattle.Text = "0";
            // 
            // LeaderTimes
            // 
            this.LeaderTimes.AutoSize = true;
            this.LeaderTimes.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LeaderTimes.Location = new System.Drawing.Point(350, 375);
            this.LeaderTimes.Name = "LeaderTimes";
            this.LeaderTimes.Size = new System.Drawing.Size(19, 19);
            this.LeaderTimes.TabIndex = 114;
            this.LeaderTimes.Text = "0";
            // 
            // NormalTimes
            // 
            this.NormalTimes.AutoSize = true;
            this.NormalTimes.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NormalTimes.Location = new System.Drawing.Point(350, 325);
            this.NormalTimes.Name = "NormalTimes";
            this.NormalTimes.Size = new System.Drawing.Size(19, 19);
            this.NormalTimes.TabIndex = 113;
            this.NormalTimes.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(250, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 112;
            this.label13.Text = "Leader";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(250, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 111;
            this.label14.Text = "Normal";
            // 
            // LMTimes
            // 
            this.LMTimes.AutoSize = true;
            this.LMTimes.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LMTimes.Location = new System.Drawing.Point(350, 475);
            this.LMTimes.Name = "LMTimes";
            this.LMTimes.Size = new System.Drawing.Size(19, 19);
            this.LMTimes.TabIndex = 118;
            this.LMTimes.Text = "0";
            // 
            // MVPTimes
            // 
            this.MVPTimes.AutoSize = true;
            this.MVPTimes.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MVPTimes.Location = new System.Drawing.Point(350, 425);
            this.MVPTimes.Name = "MVPTimes";
            this.MVPTimes.Size = new System.Drawing.Size(19, 19);
            this.MVPTimes.TabIndex = 117;
            this.MVPTimes.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(250, 475);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 19);
            this.label17.TabIndex = 116;
            this.label17.Text = "L/M";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(250, 425);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 19);
            this.label18.TabIndex = 115;
            this.label18.Text = "MVP";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(400, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 19);
            this.label19.TabIndex = 120;
            this.label19.Text = "战斗次数: x";
            // 
            // BattleTimes
            // 
            this.BattleTimes.DisplayMember = "1";
            this.BattleTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BattleTimes.FormattingEnabled = true;
            this.BattleTimes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BattleTimes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.BattleTimes.Location = new System.Drawing.Point(510, 100);
            this.BattleTimes.Name = "BattleTimes";
            this.BattleTimes.Size = new System.Drawing.Size(50, 23);
            this.BattleTimes.TabIndex = 121;
            this.BattleTimes.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(400, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 19);
            this.label8.TabIndex = 122;
            this.label8.Text = "场";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPercent.Location = new System.Drawing.Point(684, 272);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(0, 20);
            this.labelPercent.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(50, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 124;
            this.label9.Text = "1";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEnd.Location = new System.Drawing.Point(648, 250);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(0, 19);
            this.labelEnd.TabIndex = 125;
            // 
            // labelTotalExp
            // 
            this.labelTotalExp.AutoSize = true;
            this.labelTotalExp.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTotalExp.Location = new System.Drawing.Point(624, 305);
            this.labelTotalExp.Name = "labelTotalExp";
            this.labelTotalExp.Size = new System.Drawing.Size(19, 19);
            this.labelTotalExp.TabIndex = 126;
            this.labelTotalExp.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(525, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 127;
            this.label10.Text = "还差经验：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(400, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 19);
            this.label11.TabIndex = 128;
            this.label11.Text = "所计算场次不考虑扩编等级变动";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 42);
            this.button1.TabIndex = 129;
            this.button1.Text = "不清楚自己该刷哪个图？";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReadRecord,
            this.DeleteRecord,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 28);
            this.menuStrip1.TabIndex = 130;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ReadRecord
            // 
            this.ReadRecord.Name = "ReadRecord";
            this.ReadRecord.Size = new System.Drawing.Size(81, 24);
            this.ReadRecord.Text = "读取记录";
            this.ReadRecord.Click += new System.EventHandler(this.读取记录ToolStripMenuItem_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(81, 24);
            this.DeleteRecord.Text = "清除记录";
            this.DeleteRecord.Click += new System.EventHandler(this.清除记录ToolStripMenuItem_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(51, 24);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // ExpEachx1
            // 
            this.ExpEachx1.AutoSize = true;
            this.ExpEachx1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExpEachx1.Location = new System.Drawing.Point(172, 375);
            this.ExpEachx1.Name = "ExpEachx1";
            this.ExpEachx1.Size = new System.Drawing.Size(19, 19);
            this.ExpEachx1.TabIndex = 132;
            this.ExpEachx1.Text = "0";
            // 
            // labelEachx1
            // 
            this.labelEachx1.AutoSize = true;
            this.labelEachx1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEachx1.Location = new System.Drawing.Point(50, 375);
            this.labelEachx1.Name = "labelEachx1";
            this.labelEachx1.Size = new System.Drawing.Size(123, 19);
            this.labelEachx1.TabIndex = 131;
            this.labelEachx1.Text = "每战基础经验";
            // 
            // ExpEveryTime
            // 
            this.ExpEveryTime.AutoSize = true;
            this.ExpEveryTime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExpEveryTime.Location = new System.Drawing.Point(172, 475);
            this.ExpEveryTime.Name = "ExpEveryTime";
            this.ExpEveryTime.Size = new System.Drawing.Size(19, 19);
            this.ExpEveryTime.TabIndex = 134;
            this.ExpEveryTime.Text = "0";
            // 
            // labelExpEveryTime
            // 
            this.labelExpEveryTime.AutoSize = true;
            this.labelExpEveryTime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExpEveryTime.Location = new System.Drawing.Point(50, 475);
            this.labelExpEveryTime.Name = "labelExpEveryTime";
            this.labelExpEveryTime.Size = new System.Drawing.Size(123, 19);
            this.labelExpEveryTime.TabIndex = 133;
            this.labelExpEveryTime.Text = "每场基础经验";
            // 
            // buttonHasExp
            // 
            this.buttonHasExp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonHasExp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHasExp.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonHasExp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHasExp.Location = new System.Drawing.Point(43, 91);
            this.buttonHasExp.Name = "buttonHasExp";
            this.buttonHasExp.Size = new System.Drawing.Size(97, 34);
            this.buttonHasExp.TabIndex = 135;
            this.buttonHasExp.Text = "已有经验";
            this.buttonHasExp.UseVisualStyleBackColor = false;
            this.buttonHasExp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(485, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 136;
            this.label3.Text = "到下一级还需要";
            // 
            // labelNextLvTimes
            // 
            this.labelNextLvTimes.AutoSize = true;
            this.labelNextLvTimes.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNextLvTimes.Location = new System.Drawing.Point(624, 334);
            this.labelNextLvTimes.Name = "labelNextLvTimes";
            this.labelNextLvTimes.Size = new System.Drawing.Size(19, 19);
            this.labelNextLvTimes.TabIndex = 137;
            this.labelNextLvTimes.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(642, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 19);
            this.label15.TabIndex = 138;
            this.label15.Text = "场";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(778, 529);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelNextLvTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonHasExp);
            this.Controls.Add(this.ExpEveryTime);
            this.Controls.Add(this.labelExpEveryTime);
            this.Controls.Add(this.ExpEachx1);
            this.Controls.Add(this.labelEachx1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelTotalExp);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BattleTimes);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.LMTimes);
            this.Controls.Add(this.MVPTimes);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.LeaderTimes);
            this.Controls.Add(this.NormalTimes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ExpEachBattle);
            this.Controls.Add(this.DecreaseLv);
            this.Controls.Add(this.labelExpEachBattle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lv100Progress);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BonusCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExpandTimes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.HasExp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TargetLv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InitialLv);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " GfExp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InitialLv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TargetLv;
        private System.Windows.Forms.TextBox HasExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Map;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ExpandTimes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox BonusCheck;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ProgressBar Lv100Progress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelExpEachBattle;
        private System.Windows.Forms.Label DecreaseLv;
        private System.Windows.Forms.Label ExpEachBattle;
        private System.Windows.Forms.Label LeaderTimes;
        private System.Windows.Forms.Label NormalTimes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LMTimes;
        private System.Windows.Forms.Label MVPTimes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox BattleTimes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelTotalExp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ReadRecord;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem DeleteRecord;
        private System.Windows.Forms.Label ExpEachx1;
        private System.Windows.Forms.Label labelEachx1;
        private System.Windows.Forms.Label ExpEveryTime;
        private System.Windows.Forms.Label labelExpEveryTime;
        private System.Windows.Forms.Button buttonHasExp;
        private System.Windows.Forms.ToolTip toolTipPrompt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNextLvTimes;
        private System.Windows.Forms.Label label15;
    }
}

