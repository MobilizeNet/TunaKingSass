
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as TKS from './components/tks';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    WebMapKendoModule,
    WebMapModule,
  ],
  exports: [
    TKS.CustomersOrdersComponent,
    TKS.FrmBillManagmentComponent,
    TKS.frmCustomerComponent,
    TKS.frmListComponent,
    TKS.frmListDataComponent,
    TKS.frmListtabPage1Component,
    TKS.frmListtbpCustomersComponent,
    TKS.frmListtbpProductsComponent,
    TKS.frmListtbpUsersComponent,
    TKS.frmMainComponent,
    TKS.frmOrdersComponent,
    TKS.frmProductComponent,
    TKS.frmRolesComponent,
    TKS.frmUserComponent,
    TKS.frmWhiteFormComponent,
    TKS.frmWhiteFormInheritanceComponent,
    TKS.ucOkCancelComponent,
    TKS.UOCollapsableControlComponent,
  ],
  declarations: [
    TKS.CustomersOrdersComponent,
    TKS.FrmBillManagmentComponent,
    TKS.frmCustomerComponent,
    TKS.frmListComponent,
    TKS.frmListDataComponent,
    TKS.frmListtabPage1Component,
    TKS.frmListtbpCustomersComponent,
    TKS.frmListtbpProductsComponent,
    TKS.frmListtbpUsersComponent,
    TKS.frmMainComponent,
    TKS.frmOrdersComponent,
    TKS.frmProductComponent,
    TKS.frmRolesComponent,
    TKS.frmUserComponent,
    TKS.frmWhiteFormComponent,
    TKS.frmWhiteFormInheritanceComponent,
    TKS.ucOkCancelComponent,
    TKS.UOCollapsableControlComponent,
  ],
  bootstrap: [
    TKS.CustomersOrdersComponent,
    TKS.FrmBillManagmentComponent,
    TKS.frmCustomerComponent,
    TKS.frmListComponent,
    TKS.frmListDataComponent,
    TKS.frmListtabPage1Component,
    TKS.frmListtbpCustomersComponent,
    TKS.frmListtbpProductsComponent,
    TKS.frmListtbpUsersComponent,
    TKS.frmMainComponent,
    TKS.frmOrdersComponent,
    TKS.frmProductComponent,
    TKS.frmRolesComponent,
    TKS.frmUserComponent,
    TKS.frmWhiteFormComponent,
    TKS.frmWhiteFormInheritanceComponent,
    TKS.ucOkCancelComponent,
    TKS.UOCollapsableControlComponent,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class TKSModule { }

