import { Component, ChangeDetectorRef, ElementRef
, Renderer2, ViewEncapsulation} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { ControlContainerComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tksfrm-list-frm-listtbp-users",
   styleUrls : ["./frm-listtbp-users.component.scss"],
   templateUrl : "./frm-listtbp-users.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["TKS.frmList.tabpage.tpgOrders.tbpUsers"])
export class frmListtbpUsersComponent extends ControlContainerComponent {
   constructor (webMapService : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(webMapService,changeDetector,render2,elem);
   }
}