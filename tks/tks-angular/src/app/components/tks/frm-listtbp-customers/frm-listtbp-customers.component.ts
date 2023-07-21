import { Component, ChangeDetectorRef, ElementRef
, Renderer2, ViewEncapsulation} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { ControlContainerComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tksfrm-list-frm-listtbp-customers",
   styleUrls : ["./frm-listtbp-customers.component.scss"],
   templateUrl : "./frm-listtbp-customers.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["TKS.frmList.tabpage.tpgOrders.tbpCustomers"])
export class frmListtbpCustomersComponent extends ControlContainerComponent {
   constructor (webMapService : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(webMapService,changeDetector,render2,elem);
   }
}