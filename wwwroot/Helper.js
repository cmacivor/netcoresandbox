
window.CaseForm = window.CaseForm || {};
window.BingMap = window.BingMap || {};
window.Register = window.Register || {};
window.CaseForm.ClearList = (elementId) => {
    //document.getElementById(elementId).innerHTML = "";
    alert(elementId);
};
window.BingMap.OpenModalOnSearch = () => {
    $("#addressModal").modal('show');
    //return alert('test');
};
window.BingMap.HideModal = () => {
    $("#addressModal").modal('hide');
};
window.Register.OpenError = () => {
    $("#divError").show();
};
window.Register.HideError = () => {
    $("#divError").hide();
}
