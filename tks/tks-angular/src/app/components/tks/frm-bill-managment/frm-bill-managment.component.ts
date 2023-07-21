import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tks-electronic-bill-forms-frm-bill-managment",
   styleUrls : ["./frm-bill-managment.component.scss"],
   templateUrl : "./frm-bill-managment.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmTKSElectronicBillFormsFrmBillManagment"])
export class FrmBillManagmentComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}