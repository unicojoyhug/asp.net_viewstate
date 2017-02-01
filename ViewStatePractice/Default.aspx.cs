using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStatePractice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void countButton_Click(object sender, EventArgs e) {
            int counter;
            if (ViewState["counter"] == null) {
                counter = 1;
            } else {
                counter = (int)ViewState["counter"] + 1;
            }
            ViewState["counter"] = counter;
            counterLabel.Text = counter.ToString();
        }

        protected void clearButton_Click(object sender, EventArgs e) {
            if (ViewState["counter"] != null)
                ViewState.Remove("counter");
            counterLabel.Text = string.Empty;

        }
    }
}