import { ControlComponent} from "@mobilize/winforms-components";
import { isSingleUpperCaseChar} from "@mobilize/wm-netsupport";
import { UpdateState} from "@mobilize/base-components";
import { RegexHelper} from "@mobilize/wm-netsupport";
import { registerModel} from "@mobilize/webmap-core";
@registerModel("TKS.ValidationCommon")
export class ValidationCommon {
   @UpdateState()
   public static IsValidNameCase (control : ControlComponent) : boolean {
      // This code Should be moving to the FE.
      return !(control.text) || !isSingleUpperCaseChar((control.text)[0]);
   }
   @UpdateState()
   public IsValidPassword (pass : string) : boolean {
      return RegexHelper.isMatch(
      pass, `^.*(?=.{8,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$`);
   }
}