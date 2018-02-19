function workAge(){
  //Sun Oct 23 2005 00:00:00 GMT+0200 (South Africa Standard Time)
  
  var currentDate = new Date();
  var birthDate = Xrm.Page.getAttribute('birthdate').getValue();
  window.alert(birthDate);
  var dateDiff = currentDate.getMonth() - birthDate.Month();

  if (dateDiff > -1) {
    Xrm.Page.getAttribute('di_age').setValue(currentDate.getFullYear - birthDate.getFullYear);
  }
  else {
    Xrm.Page.getAttribute('di_age').setValue(currentDate.getFullYear - birthDate.getFullYear - 1);
  }
 
}