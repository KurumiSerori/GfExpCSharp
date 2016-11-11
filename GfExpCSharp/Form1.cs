using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GfExpCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExpandTimes.SelectedIndex = 0;
            BattleTimes.SelectedIndex = 0;
            HasExp.Text = "0";
            if (!initialFlag)
            {
                initialArray();
                initialMapInfo();
                initialFlag = true;
            }
            if(System.IO.File.Exists("record"))
            {
                ReadRecord.Enabled = DeleteRecord.Enabled = true;
            }
            else
            {
                ReadRecord.Enabled = DeleteRecord.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTipPrompt.SetToolTip(buttonHasExp, "点击按钮可以切换已有经验/剩余经验模式");
            toolTipPrompt.SetToolTip(CalculateButton, "计算结果");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(InitialLv.Text);
            int expand;
            if (selected < 10) expand = 1;
            else if (selected < 30) expand = 2;
            else if (selected < 70) expand = 3;
            else if (selected < 90) expand = 4;
            else expand = 5;
            ExpandTimes.Text = Convert.ToString(expand);
        }

        int[] expByLv = new int[100];
        bool initialFlag = false;
        int ExpToLv100;
        private void initialArray()
        {
            int i;
            for(i = 1; i <= 26; ++i)
            {
                expByLv[i] = 100 * i;
            }
            for(i = 27; i <= 29; ++i)
            {
                expByLv[i] = 2800 + 300 * (i - 27);
            }
            for(i = 30; i <= 35; ++i)
            {
                expByLv[i] = 4200 + 400 * (i - 30);
            }
            for(i = 36; i <= 39; ++i)
            {
                expByLv[i] = 6700 + 500 * (i - 36);
            }
            expByLv[40] = 8800;
            for(i = 41; i <= 44; ++i)
            {
                expByLv[i] = 9300 + 600 * (i - 41);
            }
            expByLv[45] = 11800;
            expByLv[46] = 12500;
            expByLv[47] = 13100;
            expByLv[48] = 13900;
            expByLv[49] = 14600;
            expByLv[50] = 15400;
            expByLv[51] = 16100;
            expByLv[52] = 16900;
            for(i = 53; i <= 57; ++i)
            {
                expByLv[i] = 17700 + 900 * (i - 53);
            }
            for(i = 58; i<= 62; ++i)
            {
                expByLv[i] = 22300 + 1000 * (i - 58);
            }
            for(i = 63; i <= 65; ++i)
            {
                expByLv[i] = 27400 + 1100 * (i - 63);
            }
            for(i = 66; i <= 69; ++i)
            {
                expByLv[i] = 30800 + 1200 * (i - 66);
            }
            expByLv[70] = 45100;
            for(i = 71; i <= 75; ++i)
            {
                expByLv[i] = 46800 + 1800 * (i - 71);
            }
            expByLv[76] = 55900;
            expByLv[77] = 57900;
            expByLv[78] = 59800;
            for(i = 79; i <= 82; ++i)
            {
                expByLv[i] = 61800 + 2100 * (i - 79);
            }
            expByLv[83] = 70300;
            expByLv[84] = 72600;
            expByLv[85] = 74800;
            for(i = 86; i <= 89; ++i)
            {
                expByLv[i] = 77100 + 2400 * (i - 86);
            }
            expByLv[90] = 112600;
            expByLv[91] = 116100;
            expByLv[92] = 119500;
            expByLv[93] = 123100;
            expByLv[94] = 126700;
            expByLv[95] = 130400;
            expByLv[96] = 134100;
            for(i = 97; i <= 99; ++i)
            {
                expByLv[i] = 137900 + 3900 * (i - 97);
            }
            ExpToLv100 = 0;
            for (i = 1; i <= 99; ++i) ExpToLv100 += expByLv[i];
        }

        int[,] mapInfo = new int[10, 3]; // DecreaseLv, ExpEachBattle, BattleTimesUsually
        private void initialMapInfo()
        {
            mapInfo[1, 0] = 35;
            mapInfo[1, 1] = 250;
            mapInfo[1, 2] = 3;
            mapInfo[2, 0] = 60;
            mapInfo[2, 1] = 320;
            mapInfo[2, 2] = 2;
            mapInfo[3, 0] = 75;
            mapInfo[3, 1] = 370;
            mapInfo[3, 2] = 4;
            mapInfo[4, 0] = 80;
            mapInfo[4, 1] = 380;
            mapInfo[4, 2] = 2;
            mapInfo[5, 0] = 80;
            mapInfo[5, 1] = 380;
            mapInfo[5, 2] = 4;
            mapInfo[6, 0] = 93;
            mapInfo[6, 1] = 430;
            mapInfo[6, 2] = 2;
        }

        int initialLv, hasExp, targetLv, mapSelect, expandTimes, battleTimes;

        private void Map_SelectedIndexChanged(object sender, EventArgs e)
        {
            BattleTimes.Text = Convert.ToString(mapInfo[Convert.ToInt32(Map.SelectedIndex) + 1, 2]);
        }

        bool bonusCheck;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lv\tMap\n" + "1-30\t21E(35)\n" + "40-60\t33E(60)\n" + "60-80\t43E(75)/44E(80)\n" + "70-93\t54(80)/54E(93)\n" + "93-100\t54E(93)");
        }

        private void 读取记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String record = System.IO.File.ReadAllText("record");
                // MessageBox.Show(record);
                String[] pArray = record.Split(' ');
                // MessageBox.Show(pArray.Length.ToString());
                if (pArray.Length < 5) return;
                InitialLv.Text = pArray[0];
                HasExp.Text = pArray[1];
                TargetLv.Text = pArray[2];
                Map.Text = pArray[3];
                choice = Convert.ToInt32(pArray[4]);
                buttonHasExp.Text = hasExpText[choice];
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine(e.ToString());
                ReadRecord.Enabled = false;
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GfExp, " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "版\n" + "Copyright(C) 2016\n\n" + "Contact me:\n" + "hakureicode#gmail.com\n" + "Weibo@胡桃灵梦", "About");
            // MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString());
        }
        

        private void 清除记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists("record"))
                {
                    System.IO.File.Delete("record");
                    ReadRecord.Enabled = DeleteRecord.Enabled = false;
                }
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine(e.ToString());
                DeleteRecord.Enabled = false;
            }
        }

        String[] hasExpText = new String[2]{"已有经验", "离下一级"};
        int choice = 0;
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(hasExpText[0]);
            //MessageBox.Show(hasExpText[1]);
            choice = 1 - choice;
            buttonHasExp.Text = hasExpText[choice];
        }

        private bool setParameters()
        {
            initialLv = Convert.ToInt32(InitialLv.Text);
            String hasExpString = HasExp.Text;
            if (String.IsNullOrEmpty(hasExpString)) hasExp = 0;
            else
            {
                if (hasExpString.Length > 8) return false;
                if (!hasExpString.All(char.IsDigit)) return false;
                // hasExp = String.IsNullOrEmpty(HasExp.Text) ? 0 : Convert.ToInt32(HasExp.Text);
                hasExp = Convert.ToInt32(hasExpString);
            }
            HasExp.Text = Convert.ToString(hasExp);
            hasExp = (choice == 0) ? hasExp : expByLv[initialLv] - hasExp;
            targetLv = Convert.ToInt32(TargetLv.Text);
            mapSelect = Convert.ToInt32(Map.SelectedIndex);
            // MessageBox.Show(mapSelect.ToString());
            expandTimes = String.IsNullOrEmpty(ExpandTimes.Text) ?  1 : Convert.ToInt32(ExpandTimes.Text);
            ExpandTimes.Text = Convert.ToString(expandTimes);
            battleTimes = String.IsNullOrEmpty(BattleTimes.Text) ? mapInfo[mapSelect + 1, 2] : Convert.ToInt32(BattleTimes.Text);
            BattleTimes.Text = Convert.ToString(battleTimes);
            bonusCheck = BonusCheck.Checked;
            if (initialLv >= targetLv) return false;
            if (hasExp < 0 || hasExp > expByLv[initialLv] || hasExp < 0) return false;
            return true;
        }

        private bool checkParameters()
        {
            if(String.IsNullOrEmpty(InitialLv.Text) || 
                // String.IsNullOrEmpty(HasExp.Text) || 
                String.IsNullOrEmpty(TargetLv.Text) || 
                String.IsNullOrEmpty(Map.Text) 
            ) return false;
            return true;
        }

        int nextLvTimes, normalTimes, leaderTimes, mvpTimes, lmTimes;

        private void calTimes(int decreaseLv, double expEachBattle)
        {
            int i;
            double nowExp = hasExp;
            while (nowExp < expByLv[initialLv])
            {
                nowExp += expEachBattle;
                nextLvTimes++;
            }

            nowExp = hasExp;
            for (i = initialLv; i < decreaseLv && i < targetLv;)
            {
                nowExp += expEachBattle;
                normalTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv; i < decreaseLv + 10 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.8;
                normalTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 10; i < decreaseLv + 20 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.6;
                normalTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 20; i < decreaseLv + 30 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.4;
                normalTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 30; i < decreaseLv + 40 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.2;
                normalTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 40; i < targetLv;)
            {
                nowExp += 5;
                normalTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }

            nowExp = hasExp;
            for (i = initialLv; i < decreaseLv && i < targetLv;)
            {
                nowExp += expEachBattle * 1.2;
                leaderTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv; i < decreaseLv + 10 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.8 * 1.2;
                leaderTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 10; i < decreaseLv + 20 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.6 * 1.2;
                leaderTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 20; i < decreaseLv + 30 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.4 * 1.2;
                leaderTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 30; i < decreaseLv + 40 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.2 * 1.2;
                leaderTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 40; i < targetLv;)
            {
                nowExp += 5;
                leaderTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }

            nowExp = hasExp;
            for (i = initialLv; i < decreaseLv && i < targetLv;)
            {
                nowExp += expEachBattle * 1.3;
                mvpTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv; i < decreaseLv + 10 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.8 * 1.3;
                mvpTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 10; i < decreaseLv + 20 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.6 * 1.3;
                mvpTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 20; i < decreaseLv + 30 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.4 * 1.3;
                mvpTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 30; i < decreaseLv + 40 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.2 * 1.3;
                mvpTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 40; i < targetLv;)
            {
                nowExp += 5;
                mvpTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }

            nowExp = hasExp;
            for (i = initialLv; i < decreaseLv && i < targetLv;)
            {
                nowExp += expEachBattle * 1.2 * 1.3;
                lmTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv; i < decreaseLv + 10 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.8 * 1.2 * 1.3;
                lmTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 10; i < decreaseLv + 20 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.6 * 1.2 * 1.3;
                lmTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 20; i < decreaseLv + 30 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.4 * 1.2 * 1.3;
                lmTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 30; i < decreaseLv + 40 && i < targetLv;)
            {
                nowExp += expEachBattle * 0.2 * 1.2 *1.3;
                lmTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
            for (i = decreaseLv + 40; i < targetLv;)
            {
                nowExp += 5;
                lmTimes++;
                if (nowExp >= expByLv[i])
                {
                    nowExp -= expByLv[i];
                    ++i;
                }
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (checkParameters())
            {
                if (!setParameters())
                {
                    Console.WriteLine("ilv, tlv, hasExp with setParameters()");
                    return;
                }
            }
            else
            {
                // MessageBox.Show("Parameters");
                Console.WriteLine("Parameters with checkParameters()");
                return;
            }
            int i;
            int totalExp = 0;
            int achievedExp = 0;
            for(i = 1; i< initialLv; ++i)
            {
                achievedExp += expByLv[i];
            }
            achievedExp += hasExp;
            for (i = initialLv; i < targetLv; ++i)
            {
                totalExp += expByLv[i];
            }
            totalExp -= hasExp;
            labelTotalExp.Text = Convert.ToString(totalExp);
            double progress = (double)achievedExp / ((double)achievedExp + (double)totalExp) * 100;
            Lv100Progress.Value = (int)progress;
            labelPercent.Text = Convert.ToDouble(progress).ToString("0.00") + "%";
            labelEnd.Text = Convert.ToString(targetLv);
            // MessageBox.Show("Total Exp: " + Convert.ToString(totalExp));

            double bonus = bonusCheck ? 1.5 : 1;
            int decreaseLv = mapInfo[mapSelect + 1, 0];
            DecreaseLv.Text = Convert.ToString(decreaseLv);
            labelExpEachBattle.Text = "每战经验(x" + Convert.ToString(expandTimes) + ")";
            double expEachBattle = mapInfo[mapSelect + 1, 1] * (expandTimes * 0.5 + 0.5) * bonus;
            ExpEachBattle.Text = Convert.ToString(expEachBattle);
            //labelEachx1.Text = "每战经验(x1)";
            ExpEachx1.Text = Convert.ToString(mapInfo[mapSelect + 1, 1]);
            //labelExpEveryTime.Text = "每场经验(x" + Convert.ToString(battleTimes) + ")";
            ExpEveryTime.Text = Convert.ToString(expEachBattle * battleTimes);

            nextLvTimes = normalTimes = leaderTimes = mvpTimes = lmTimes = 0;
            calTimes(decreaseLv, expEachBattle);

            labelNextLvTimes.Text = Convert.ToString(Math.Ceiling((double)nextLvTimes / (double)battleTimes));
            NormalTimes.Text = Convert.ToString(Math.Ceiling((double)normalTimes / (double)battleTimes));
            LeaderTimes.Text = Convert.ToString(Math.Ceiling((double)leaderTimes / (double)battleTimes));
            MVPTimes.Text = Convert.ToString(Math.Ceiling((double)mvpTimes / (double)battleTimes));
            LMTimes.Text = Convert.ToString(Math.Ceiling((double)lmTimes / (double)battleTimes));
            // NormalTimes.Text = Convert.ToString(Math.Ceiling(((double)totalExp / Convert.ToDouble(ExpEachBattle.Text)) / (double)battleTimes / bonus));
            // LeaderTimes.Text = Convert.ToString(Math.Ceiling(((double)totalExp / Convert.ToDouble(ExpEachBattle.Text)) / (double)battleTimes / bonus / 1.2));
            // MVPTimes.Text = Convert.ToString(Math.Ceiling(((double)totalExp / Convert.ToDouble(ExpEachBattle.Text)) / (double)battleTimes / bonus / 1.3));
            // LMTimes.Text = Convert.ToString(Math.Ceiling(((double)totalExp / Convert.ToDouble(ExpEachBattle.Text)) / (double)battleTimes / bonus / 1.2 / 1.3));

            System.IO.File.WriteAllText("record", InitialLv.Text + " " + HasExp.Text + " " + TargetLv.Text + " " + Map.Text + " " + choice.ToString());
            DeleteRecord.Enabled = true;
            ReadRecord.Enabled = true;
        }
    }
}
