var buttonUrl = document.getElementById("button_url");
var buttonFile = document.getElementById("button_file");
var formUrl = document.getElementById("form_url");
var formFile = document.getElementById("form_file");

buttonUrl.addEventListener("click", () => {
    formUrl.classList.remove("hide");
    formFile.classList.add("hide");
    buttonUrl.classList.add("clicked");
    buttonFile.classList.remove("clicked");
});

buttonFile.addEventListener("click", () => {
    formFile.classList.remove("hide");
    formUrl.classList.add("hide");
    buttonUrl.classList.remove("clicked");
    buttonFile.classList.add("clicked");
});
