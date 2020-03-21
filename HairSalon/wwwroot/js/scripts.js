let path = window.location.href.split("/");

switch (path[3]) {
  case "stylists":
    $(".stylists").addClass("active");
    break;
  case "clients":
    $(".client").addClass("active");
    break;
  case "":
    $(".home").addClass("active");
    break;
}
