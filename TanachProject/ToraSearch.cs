using DAL__data_access;
using DTO_Global;
using System.Windows.Forms;
using bll_services_3;
using static System.Net.Mime.MediaTypeNames;
/*tranperensy,opasity
 panel1.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Size = new Size(100, 100);
                b.Location = new Point(b.Width * i, 0);
                b.Text = i.ToString();
                b.Font = new Font("David", 36);
                panel1.Controls.Add(b);
            }*/
namespace PL_presentation
{

    enum eMode { regularSearch, initialSearch ,middleSearch,combined}
    public partial class ToraSearch : Form
    {

        #region------------- משתני מחלקה- שומרים את התשובות הנוכחיות, המצב הנוכחי ועוד---------
        private List<Result> answerList;
        private eMode mode = eMode.regularSearch;
        private int indexForRegular = 0;
        private int indexForInitial = 0;
        private int indexForMiddle = 0;
        private int indexForCombined = 0;
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case eMode.regularSearch:
                    {
                        doRegularSearch();
                        break;
                    }
                case eMode.initialSearch:
                    {
                        doInitialSearch();
                        break;
                    }
                case eMode.middleSearch:
                    doMiddleSearch();
                    break;
                case eMode.combined:
                    {
                        doCombinedSearch();
                        break;
                    }
                default:
                    break;
            }


        }


        #region ------פונקציות ביצוע חיפוש------------
        void doRegularSearch()
        {
            button2.Enabled = true;
            dataGridView1.Visible = false;
            panel1.Size = new System.Drawing.Size(1105, 327);
            indexForRegular = 0;
            answerList = bll_services_3.SearchMetheds.SearchWord(textBox1.Text);
            if (answerList.Count != 0)
            {
                int num = 100;
                if (answerList.Count() < 100)
                    num = answerList.Count();
                label1.Text = " נמצאו " + answerList.Count().ToString() + " תוצאות, מוצגות " + num + " מתוכן" +
                    "";
                showListAsTextOnPanel(answerList);
            }
            else
                label1.Text = "לא נמצאו תוצאות";
        }

        private void doCombinedSearch()
        {
            button2.Enabled = true;
            dataGridView1.Visible = false;
            panel1.Size = new System.Drawing.Size(1105, 327);
            indexForCombined = 0;
            answerList = bll_services_3.SearchMetheds.SearchCombined(textBox1.Text);
            if (answerList.Count != 0)
            {
                int num = 100;
                if (answerList.Count() < 100)
                    num = answerList.Count();
                label1.Text = " נמצאו " + answerList.Count().ToString() + " תוצאות, מוצגות " + num + " מתוכן" +
                    "";
                showListAsTextOnPanel(answerList);
            }
            else
                label1.Text = "לא נמצאו תוצאות";
        }
        private void doMiddleSearch()
        {
            button2.Enabled = true;
            dataGridView1.Visible = false;
            panel1.Size = new System.Drawing.Size(1105, 327);
            indexForMiddle = 0;
            answerList = bll_services_3.SearchMetheds.SearchMiddle(textBox1.Text);
            if (answerList.Count != 0)
            {
                int num = 100;
                if (answerList.Count() < 100)
                    num = answerList.Count();
                label1.Text = " נמצאו " + answerList.Count().ToString() + " תוצאות, מוצגות " + num + " מתוכן" +
                    "";
                showListAsTextOnPanel(answerList);
            }
            else
                label1.Text = "לא נמצאו תוצאות";
        }
        private void doInitialSearch()
        {
            button2.Enabled = true;
            dataGridView1.Visible = false;
            panel1.Size = new System.Drawing.Size(1105, 327);
            indexForInitial = 0;
            answerList = bll_services_3.SearchMetheds.SearchInitial(textBox1.Text);
            if (answerList.Count() != 0)
            {
                int num = 100;
                if (answerList.Count() < 100)
                    num = answerList.Count();
                label1.Text = " נמצאו " + answerList.Count().ToString() + " תוצאות, מוצגות " + num + " מתוכן" +
                    "";
                showListAsTextOnPanel(answerList);
            }
            else
                label1.Text = "לא נמצאו תוצאות";
        }
        #endregion

        private void showListAsTextOnPanel(List<Result> listToShow)
        {

            switch (mode)
            {
                case eMode.regularSearch:
                    ShowForRegularSearch(); break;
                case eMode.initialSearch:
                    showForInitialSearch(); break;
                case eMode.middleSearch:
                    showForMiddleSearch(); break;
                case eMode.combined:
                    showForCombinedSearch(); break;
                default:
                    break;
            }
        }




        #region ---------פונקציות הצגה על המסך----------------
        private void ShowForRegularSearch()
        {
            dataGridView1.Visible = false;
            panel1.Visible = true;
            panel1.Controls.Clear();
            int i = 0;
            for (; indexForRegular < answerList.Count && i < 100; i++, indexForRegular++)
            {
                ShowOneLineForRegularSearch(i, indexForRegular);
            }
            if (indexForRegular >= answerList.Count - 1)
            {
                button2.Enabled = false;
                if (answerList.Count > 100)
                    label1.Text = "אין עוד תשובות להצגה";
            }
        }
        private void ShowOneLineForRegularSearch(int i, int index)
        {

            //אינדקסים של תחילת וסוף המילה
            int startOfWord = answerList[index].Value.LastIndexOf(" ", answerList[index].IndexOfWord, answerList[index].IndexOfWord);
            if (startOfWord < 0)
                startOfWord = 0;
            int LenthOfWord = answerList[index].Value.IndexOf(" ", startOfWord + 1) - startOfWord + 1;
            //if (LenthOfWord < 0)
            //    LenthOfWord = listToShow[index].Value.Length - startOfWord-1;
            int start = answerList[index].IndexOfWord;
            int length = answerList[index].LengthOfWord;
            if (start + length == answerList[index].Value.Length)
                length -= 2;

            //חלק ראשון של טקסט
            Label txt1 = new Label();
            txt1.RightToLeft = RightToLeft.Yes;
            string text1 = answerList[index].Sefer + ", " + answerList[index].Perek + ", " + answerList[index].Pasuk + ": ";// + "start: " + listToShow[index].indexOfWord + " length: " + listToShow[index].LengthOfWord + "   ";
            txt1.Text = text1 + answerList[index].Value.Substring(0, startOfWord);
            //txt1.Width = txt1.Text.Length * 8;
            txt1.AutoSize = true;
            txt1.BackColor = Color.WhiteSmoke;
            txt1.BorderStyle = BorderStyle.None;
            if (txt1.Text.Contains("קץ כל בשר בא"))
                Console.WriteLine("zds");


            //חלק מודגש של טקסט

            Label txtbold = new Label();
            txtbold.RightToLeft = RightToLeft.Yes;
            string txtToShow;
            if (LenthOfWord > 0)
            {
                txtToShow = answerList[index].Value.Substring(startOfWord, LenthOfWord);
            }
            else
            {
                txtToShow = answerList[index].Value.Substring(startOfWord);
                LenthOfWord = answerList[index].Value.Length - startOfWord;
            }
            txtbold.Text = txtToShow;//listToShow[index].Value.Substring(listToShow[index].indexOfWord, listToShow[index].LengthOfWord);
                                     //txtbold.Width = txtbold.Text.Length * 9;
            txtbold.AutoSize = true;
            txtbold.BackColor = Color.Yellow;
            txtbold.BorderStyle = BorderStyle.None;


            //חלק אחרון של טקסט
            Label txt2 = new Label();
            txt2.RightToLeft = RightToLeft.Yes;
            txt2.RightToLeft = RightToLeft.Yes;
            txt2.Text = answerList[index].Value.Substring(startOfWord + LenthOfWord) + ":";
            //txt2.Width = txt2.Text.Length * 9;
            txt2.AutoSize = true;
            txt2.BackColor = Color.WhiteSmoke;
            txt2.BorderStyle = BorderStyle.None;
            txt2.AutoSize = true;



            panel1.Controls.Add(txtbold);
            panel1.Controls.Add(txt2);
            panel1.Controls.Add(txt1);

            txt1.Location = new Point(panel1.Width - txt1.Width, i * 30);
            txtbold.Location = new Point(txt1.Left - txtbold.Width, i * 30);
            txt2.Location = new Point(txtbold.Left - txt2.Width, i * 30);//new Point(panel1.Width-(txt1.Width+txtbold.Width+txt2.Width), i * 30);




        }

        private void showForInitialSearch()
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            int i = 0;
            for (; indexForInitial < answerList.Count && i < 100; i++, indexForInitial++)
            {   //חישוב הטקסטים
                Result thisPasuk = answerList[indexForInitial];
                string[] arr = thisPasuk.Value.Split(" ");
                int FirstInitial = thisPasuk.IndexOfFirstInitial;
                int LengthOfWord = thisPasuk.LengthOfWord;
                string firstTxt = thisPasuk.Sefer + ", " + thisPasuk.Perek + ", " + thisPasuk.Pasuk + ": ";
                string lastTxt = "";
                List<Label> Whites = new List<Label>();
                List<Label> Yellows = new List<Label>();
                int j;
                for (j = 0; j <= FirstInitial; j++)
                    firstTxt += arr[j] + " ";

                //הוספת לייבלים דינאמית

                for (; j <= FirstInitial + LengthOfWord; j++)
                {
                    if (arr[j] != "")
                    {
                        Label yellow = new Label();
                        yellow.Text = arr[j][0].ToString();
                        Yellows.Add(yellow);
                        Label white = new Label();
                        white.Text = arr[j].Substring(1);
                        Whites.Add(white);
                    }
                }
                for (; j < arr.Length; j++)
                {
                    lastTxt += arr[j] + " ";
                }
                // לייבל ראשון
                Label firstLbl = new Label();
                firstLbl.RightToLeft = RightToLeft.Yes;
                firstLbl.Text = firstTxt;
                firstLbl.AutoSize = true;
                firstLbl.BackColor = Color.WhiteSmoke;
                firstLbl.BorderStyle = BorderStyle.None;

                //מילוי פרמטרים דינאמי בלייבלים

                for (int k = 0; k < Yellows.Count; k++)
                {
                    Yellows[k].Margin = new Padding(0);
                    Yellows[k].AutoSize = true;
                    Yellows[k].BackColor = Color.Yellow;
                    Yellows[k].BorderStyle = BorderStyle.None;
                    Whites[k].AutoSize = true;
                    Whites[k].BackColor = Color.WhiteSmoke;
                    Whites[k].BorderStyle = BorderStyle.None;
                    Whites[k].Margin = new Padding(0);
                    Whites[k].Padding = new Padding(0);

                }

                // לייבל אחרון

                Label lastLbl = new Label();
                lastLbl.RightToLeft = RightToLeft.Yes;
                lastLbl.Text = lastTxt;
                lastLbl.AutoSize = true;
                lastLbl.BackColor = Color.WhiteSmoke;
                lastLbl.BorderStyle = BorderStyle.None;

                //אימוץ הלייבלים
                panel1.Controls.Add(firstLbl);
                for (int k = 0; k < Whites.Count; k++)
                {
                    panel1.Controls.Add(Yellows[k]);
                    panel1.Controls.Add(Whites[k]);

                }
                panel1.Controls.Add(lastLbl);

                //הגדרת מיקום לכל אחד
                firstLbl.Location = new Point(panel1.Width - firstLbl.Width, i * 30);
                if (Yellows != null && Yellows.Count > 0)
                {
                    Yellows[0].Location = new Point(firstLbl.Left - Yellows[0].Width, i * 30);
                    Whites[0].Location = new Point(Yellows[0].Left - Whites[0].Width, i * 30);
                }
                for (int k = 1; k < Yellows.Count; k++)
                {
                    Yellows[k].Location = new Point(Whites[k - 1].Left - Yellows[k].Width - 6, i * 30);
                    Whites[k].Location = new Point(Yellows[k].Left - Whites[k].Width, i * 30);
                }
                if (Yellows != null && Yellows.Count > 0)
                    lastLbl.Location = new Point(Whites[Whites.Count - 1].Left - lastLbl.Width, i * 30);
                else
                    lastLbl.Location = new Point(firstLbl.Left - lastLbl.Width, i * 30);


            }
            if (indexForInitial >= answerList.Count - 1)
            {
                button2.Enabled = false;
                if (answerList.Count > 100)
                    label1.Text = "אין עוד תשובות להצגה";
            }
        }


        private void showForMiddleSearch()
        {
            dataGridView1.Visible = false;
            panel1.Visible = true;
            panel1.Controls.Clear();
            int i = 0;
            for (; indexForMiddle < answerList.Count && i < 100; i++, indexForMiddle++)
            {
                showOneLineForMiddleSearch(i, indexForMiddle);
                if (indexForMiddle >= answerList.Count - 1)
                {
                    button2.Enabled = false;
                    if (answerList.Count > 100)
                        label1.Text = "אין עוד תשובות להצגה";
                }

            }
        }
        private void showOneLineForMiddleSearch(int i, int index)
        {
            //חישוב הטקסטים
            Result thisPasuk = answerList[index];
            string[] arr = thisPasuk.Value.Split(" ");
            int FirstMiddle = thisPasuk.IndexOfFirstMiddle;
            int LengthOfWord = thisPasuk.LengthOfWord;
            int LetterLocation = thisPasuk.LetterLocation;

            string firstTxt = thisPasuk.Sefer + ", " + thisPasuk.Perek + ", " + thisPasuk.Pasuk + ": ";
            string lastTxt = "";
            List<Label> Whites = new List<Label>();
            List<Label> Yellows = new List<Label>();
            int j;
            //firstTxt מילוי 
            //LetterLocation ואז כל האותיות במילה הזו עד,FirstMiddleכל המילים שעד ל -

            for (j = 0; j < FirstMiddle; j++)
                firstTxt += arr[j] + " ";
            firstTxt += arr[j].Substring(0, LetterLocation);

            //בניית שני הלייבלים הראשונים
            Label yellow = new Label();
            yellow.Text = arr[j][LetterLocation].ToString();
            Yellows.Add(yellow);
            Label white = new Label();
            white.Text = arr[j].Substring(LetterLocation + 1);
            Whites.Add(white);
            j++;
            for (; j < FirstMiddle + LengthOfWord && j < arr.Length; j++)
            {
                if (arr[j] != "")
                {   //השלמת הלייבל הלבן הקודם
                    Whites[Whites.Count - 1].Text += "   " + arr[j].Substring(0, LetterLocation);
                    //ייצור הלייבלים החדשים
                    yellow = new Label();
                    yellow.Text = arr[j][LetterLocation].ToString();
                    Yellows.Add(yellow);
                    white = new Label();
                    white.Text = arr[j].Substring(LetterLocation + 1);
                    Whites.Add(white);
                }
            }

            for (; j < arr.Length; j++)
            {
                lastTxt += arr[j] + " ";
            }
            // לייבל ראשון
            Label firstLbl = new Label();
            firstLbl.Text = firstTxt;
            firstLbl.AutoSize = true;
            firstLbl.BackColor = Color.WhiteSmoke;
            firstLbl.BorderStyle = BorderStyle.None;

            //מילוי פרמטרים דינאמי בלייבלים

            for (int k = 0; k < Yellows.Count; k++)
            {
                Yellows[k].Padding = new Padding(-1);
                Yellows[k].Margin = new Padding(-1);
                Yellows[k].AutoSize = true;
                Yellows[k].BackColor = Color.Yellow;
                Yellows[k].BorderStyle = BorderStyle.None;
                Whites[k].AutoSize = true;
                //Whites[k].BackColor = Color.Gainsboro;
                Whites[k].BackColor = Color.WhiteSmoke;
                Whites[k].BorderStyle = BorderStyle.None;
                Whites[k].Margin = new Padding(-1);
                Whites[k].Padding = new Padding(-1);

            }

            // לייבל אחרון

            Label lastLbl = new Label();
            lastLbl.Text = lastTxt + ":";
            lastLbl.AutoSize = true;
            lastLbl.BackColor = Color.WhiteSmoke;
            lastLbl.BorderStyle = BorderStyle.None;

            //אימוץ הלייבלים
            panel1.Controls.Add(firstLbl);
            for (int k = 0; k < Whites.Count; k++)
            {
                panel1.Controls.Add(Yellows[k]);
                panel1.Controls.Add(Whites[k]);

            }
            panel1.Controls.Add(lastLbl);

            //הגדרת מיקום לכל אחד
            firstLbl.Location = new Point(panel1.Width - firstLbl.Width, i * 30);
            if (Yellows != null && Yellows.Count > 0)
            {
                Yellows[0].Location = new Point(firstLbl.Left - Yellows[0].Width, i * 30);
                Whites[0].Location = new Point(Yellows[0].Left - Whites[0].Width, i * 30);
            }
            for (int k = 1; k < Yellows.Count; k++)
            {
                Yellows[k].Location = new Point(Whites[k - 1].Left - Yellows[k].Width, i * 30);
                Whites[k].Location = new Point(Yellows[k].Left - Whites[k].Width, i * 30);
            }
            if (Yellows != null && Yellows.Count > 0)
                lastLbl.Location = new Point(Whites[Whites.Count - 1].Left - lastLbl.Width, i * 30);
            else
                lastLbl.Location = new Point(firstLbl.Left - lastLbl.Width, i * 30);



        }

        private void showForCombinedSearch()
        {
            dataGridView1.Visible = false;
            panel1.Visible = true;
            panel1.Controls.Clear();
            int i = 0;
            for (; indexForCombined < answerList.Count && i < 100; i++, indexForCombined++)
            {
                if (answerList[indexForCombined].FoundInMiddle)
                    showOneLineForMiddleSearch(i, indexForCombined);
                if (answerList[indexForCombined].FoundWord)
                    ShowOneLineForRegularSearch(i, indexForCombined);
                if (indexForCombined >= answerList.Count - 1)
                {
                    button2.Enabled = false;
                    if (answerList.Count > 100)
                        label1.Text = "אין עוד תשובות להצגה";
                }

            }
        }
        #endregion


        #region ---הצגת כל התורה------
        private void showAllTorah()
        {
            button2.Enabled = false;
            panel1.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.Size = new Size(1077, 327);
            dataGridView1.DataSource = DataClass.psukim;
            label1.Text = "כל התורה, סך הכל " + DataClass.psukim.Count + " פסוקים ";
        }
        #endregion

        #region -------------בעת טעינה--------------
        public ToraSearch()
        {
            InitializeComponent();
            label1.Padding = new Padding(8);

            panel1.Width = 600;
            dataGridView1.Size = new Size(1077, 327);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("פותח את חיפוש בתנך \n ©️ אסתי בלוך  \n?להציג את כל התורה", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) showAllTorah();
            else
            {
                panel1.Size = new System.Drawing.Size(1105, 327);
                dataGridView1.Visible = false;
            }

        }
        #endregion


        #region //----------------פונקציות בעת לחיצה -----------------------
        private void חיפושרגילToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = eMode.regularSearch;
            if (label1.Text != "")
                doRegularSearch();
        }
        private void חיפושלפינושאToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = eMode.middleSearch;
            if (label1.Text != "")
                doMiddleSearch();


        }
        private void חיפושמשולבToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = eMode.combined;
            if (label1.Text != "")
                doCombinedSearch();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                if ((int)textBox1.Text[textBox1.TextLength - 1] == 10 ||
                (int)textBox1.Text[textBox1.TextLength - 1] == 12 ||
                (int)textBox1.Text[textBox1.TextLength - 1] == 14)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 2);
                    button1_Click(sender, e);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            showListAsTextOnPanel(answerList);
        }
        private void חיפושלפישורשToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = eMode.initialSearch;
            doInitialSearch();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            showAllTorah();
        }
        #endregion


        #region //-----------------פונקציות  ריקות------------------

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void search_options_Opening(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void חיפושרגלToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e) { }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    #endregion 

}
