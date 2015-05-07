//create a namespace for global variables
var GlobalContainer = {};

var thumbnailSize = "tile-item-medium";

function Thumbnail(size) {
    $(".tile-item").each(function () {
        $(this).removeClass("tile-item-small tile-item-medium tile-item-large tile-item-extralarge");
    });
    $(".tile-expanded").each(function () {
        //The following are for the case when full size is shown
        $(this).find(".collapsed").each(function () { $(this).show(); });
        $(this).find(".expanded").hide();
        $(this).removeClass("tile-expanded").addClass("tile-item");
        $(this).find("img").attr("onclick","CollapseImage(this);");
    });
    $("#click-message").show();
    $(".btn").removeClass("btn-selected");
    if (size == "small") {
        $(".tile-item").addClass("tile-item-small");
        thumbnailSize = "tile-item-small";
        $("#btn-small").addClass("btn-selected");
    }
    else if (size == "medium") {
        $(".tile-item").addClass("tile-item-medium");
        thumbnailSize = "tile-item-medium";
        $("#btn-medium").addClass("btn-selected");
    }
    else if (size == "large") {
        $(".tile-item").addClass("tile-item-large");
        thumbnailSize = "tile-item-large";
        $("#btn-large").addClass("btn-selected");
    }
    else if (size == "extralarge") {
        $(".tile-item").addClass("tile-item-extralarge");
        thumbnailSize = "tile-item-extralarge";
        $("#btn-extralarge").addClass("btn-selected");
    }
}
function ExpandThumbnail(element) {
    //var backgroundImage = $(element).css("backgroundImage");
    //var image = backgroundImage.split("(")[1];
    //image = image.substring(0, image.length - 1);
    $element = $(element);
    $tileDiv = $element.closest(".tile-item");
    $tileDiv.find(".collapsed").each(function () { $(this).hide(); });
    $tileDiv.removeClass("tile-item tile-item-small tile-item-medium tile-item-large tile-item-extralarge");
    $tileDiv.toggleClass("tile-expanded");
    $tileDiv.find(".expanded").show();
    $img = $tileDiv.find("img");
    $img.attr("src", $img.attr("data-source"));
    //$tileDiv.find(".long-caption").before("<img src='" + image + "'>");
}
function CollapseImage(element) {
    $element = $(element);
    $tileDiv = $element.closest(".tile-expanded");
    $tileDiv.find(".collapsed").each(function () { $(this).show(); });
    $tileDiv.find(".expanded").hide();
    $tileDiv.toggleClass("tile-expanded");
    $tileDiv.addClass("tile-item " + thumbnailSize);

}
function ExpandAll() {
    $(".btn").removeClass("btn-selected");
    $("#btn-all").addClass("btn-selected");
    $("#click-message").toggle();
    GlobalContainer.Images = $(".tile-item");
    if (GlobalContainer.Images.length > 0) {
        ExpandItem(0)
    }

}
function ExpandItem(counter) {

    $tileDiv = $(GlobalContainer.Images[counter]);
    $tileDiv.find(".collapsed").each(function () { $(this).hide(); });
    $tileDiv.removeClass("tile-item tile-item-small tile-item-medium tile-item-large tile-item-extralarge");
    $tileDiv.toggleClass("tile-expanded");
    $tileDiv.find(".expanded").show();

    $Img = $tileDiv.find("img");
    $Img.attr("onclick", null);
    $ImgUrl = $Img.attr("data-source");
    $Img.attr("src", $ImgUrl);

    if (counter < GlobalContainer.Images.length-1) {
        //$Img.load = $Img.error = function () { ExpandItem(counter + 1); }

        //This method is to handle cached images
        $Img.one('load', function () {
            ExpandItem(counter + 1);
        }).each(function () {
            //if (this.complete) { setTimeout(function () { $(this).load(); }, 300) }
            if (this.complete) { $(this).load(); }
        });

    }

    //$Img.attr("src", $ImgUrl + '?' + new Date().getTime());

}
