
window.CaseForm = window.CaseForm || {};
window.BingMap = window.BingMap || {};
window.CaseForm.ClearList = (elementId) => {
    //document.getElementById(elementId).innerHTML = "";
    alert(elementId);
};
window.BingMap.OpenModalOnSearch = () => {
    $("#addressModal").modal('show');
    //return alert('test');
}