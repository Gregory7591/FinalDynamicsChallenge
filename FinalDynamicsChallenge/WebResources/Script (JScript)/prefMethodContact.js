function onchange() {

  var prefferedContactMethodCode =
    Xrm.Page.getAttribute('preferredcontactmethodcode').getValue();


  switch (prefferedContactMethodCode) {

    case 1: ;
    case 2: clearAllMandatoryFields();
      Xrm.Page.getAttribute("emailaddress1").setRequiredLevel("required"); break;
    case 3: clearAllMandatoryFields();
      Xrm.Page.getAttribute("mobilephone").setRequiredLevel("required"); break;
    case 4: clearAllMandatoryFields();
      Xrm.Page.getAttribute("fax").setRequiredLevel("required"); break;
    default: break;
  }


  function clearAllMandatoryFields() {
    Xrm.Page.getAttribute("mobilephone").setRequiredLevel("none");
    Xrm.Page.getAttribute("fax").setRequiredLevel("none");
  }

}