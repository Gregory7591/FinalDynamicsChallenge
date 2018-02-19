
function clearAllMandatoryFields() {
  Xrm.Page.getAttribute("mobilephone").setRequiredLevel("none");
  Xrm.Page.getAttribute("fax").setRequiredLevel("none");
}

function onload() {//jmjm
  var prefferedContactMethodCode =
    Xrm.Page.getAttribute('preferredcontactmethodcode').getValue();

  clearAllMandatoryFields();
  switch (prefferedContactMethodCode) {

    case 1: ;
    case 2: Xrm.Page.getAttribute("emailaddress1").setRequiredLevel("required"); break;
    case 3: Xrm.Page.getAttribute("mobilephone").setRequiredLevel("required"); break;
    case 4: Xrm.Page.getAttribute("fax").setRequiredLevel("required"); break;
    default: break;
  }

}
