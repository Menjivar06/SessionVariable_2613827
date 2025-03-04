using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionVariable_2613827
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            // Save the Variables.
            Session["ddlCategory"] = ddlCategory.SelectedValue;
            Session["ddlSupplier"] = ddlSupplier.SelectedValue;
            Session["strProduct"] = txtProduct.Text;
            Session["strDescription"] = txtDescription.Text;
            Session["strImage"] = txtImagen.Text;
            Session["decPrice"] = txtPrice.Text;
            Session["bytNumberInStock"] = txtNumberInStock.Text;
           Session["bytNumberOnOrder"] = txtNumberOnOrder.Text;
           Session["bytReorderLevel"] = txtReorderLevel.Text;

            // Go to the confirmation page.
            Response.Redirect("ProductConfirmCookies.aspx");
        }
    }
}