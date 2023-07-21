import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tks-frm-white-form",
   styleUrls : ["./frm-white-form.component.scss"],
   templateUrl : "./frm-white-form.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmTKSfrmWhiteForm"])
export class frmWhiteFormComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}