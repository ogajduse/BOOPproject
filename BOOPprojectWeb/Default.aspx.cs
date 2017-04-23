﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOOPproject;

namespace BOOPprojectWeb {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Confirm_btn_Click(object sender, EventArgs e) {
            StringStatistics statistics = new StringStatistics(TextBox1.Text);

            ResultsTable.Rows[0].Cells[1].Text = Convert.ToString(statistics.GetSentencesNumber());
            ResultsTable.Rows[1].Cells[1].Text = Convert.ToString(statistics.GetWordsNumber());
            ResultsTable.Rows[2].Cells[1].Text = Convert.ToString(statistics.GetIndicativeNumber());
            ResultsTable.Rows[3].Cells[1].Text = Convert.ToString(statistics.GetQuestionsNumber());
            ResultsTable.Rows[4].Cells[1].Text = Convert.ToString(statistics.GetImperativeNumber());
            ResultsTable.Rows[5].Cells[1].Text = Convert.ToString(statistics.GetConsonantNumber());
            ResultsTable.Rows[6].Cells[1].Text = Convert.ToString(statistics.GetVowelNumber());
            ResultsTable.Rows[7].Cells[1].Text = Convert.ToString(statistics.GetLinesNumber());
            ResultsTable.Rows[8].Cells[1].Text = Convert.ToString(statistics.GetSpecialCharactersNumber());
        }
    }
}