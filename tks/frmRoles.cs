using System;
using System.Collections.Generic;
using System.Data;
using TKS_DB;
using TKS_Models;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   [Observable]
   public partial class frmRoles
      : Mobilize.Web.Form
   {

      public frmRoles()
      {
         InitializeComponent();
      }

      [Intercepted]
      public DataTable User { get; set; }

      private void frmRoles_Load(object sender, EventArgs e)
      {
         var roles = Enum.GetValues(typeof(UserPermissions));
         var dataHandler = new DataHandler();
         foreach ( var role in roles )
         {
            this.lbxRoles.Items.Add(role);
         }
         this.User = dataHandler.GetDataSource("user_id", "user_roles", "roles.users");
         foreach ( DataRow user in this.User.Rows )
         {
            var node = this.tvwUser.Nodes.Add(user["user_id"] as string);
            node.Nodes.Add(user["user_roles"] as string);
         }
         this.tvwUser.ExpandAll();
      }

      private void ucOkCancel1_OkClick(object sender, EventArgs e)
      {
         var dataHandler = new DataHandler();
         for ( var i = 0; i < this.tvwUser.Nodes.Count; i++ )
         {
            var node = this.tvwUser.Nodes[i];
            if ( node.Checked )
            {
               dataHandler.UpdateFields(node.Text, node.Nodes[0].Text);
            }
         }
         this.Close();
      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         if ( this.lbxRoles.SelectedItem != null && this.tvwUser.SelectedNode != null )
         {
            var node = GetRootNode();
            if ( node != null )
            {
               node.Nodes[0].Text = this.lbxRoles.SelectedItem.ToString();
               node.Checked = true;
            }
         }
      }

      private void btnRemove_Click(object sender, EventArgs e)
      {
         var node = GetRootNode();
         if ( node != null )
         {
            node.Nodes[0].Text = UserPermissions.ViewOnly.ToString();
            node.Checked = true;
         }
      }

      private Mobilize.Web.TreeNode GetRootNode()
      {
         var node = this.tvwUser.SelectedNode;
         while ( node.Parent != null )
         {
            node = node.Parent;
         }
         return node;
      }

      private string GetSecurityFromText(string text)
      {
         if ( text == UserPermissions.ViewOnly.ToString() || text == UserPermissions.LowLevel.ToString() )
         {
            return "Normal User";
         }
         else if ( text == UserPermissions.Audit.ToString() || text == UserPermissions.Administrator.ToString() )
         {
            return "High Level User";
         }
         else
         {
            return "Please select a role";
         }
      }

      private void tvwUser_NodeMouseClick_1(object sender, Mobilize.Web.TreeNodeMouseClickEventArgs e)
      {
         this.txtSecurityLevel.Text = null;
      }

      private void btnSecurityLevel_Click(object sender, EventArgs e)
      {
         var text = this.tvwUser.SelectedNode.Text;
         this.txtSecurityLevel.Text = this.GetSecurityFromText(text);
      }

   }

}