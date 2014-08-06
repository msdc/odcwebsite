$(function () {
    var videos = $(".videoResource");
    var filter = videos.filter(function (index) {
        var h = $(this).attr("href");
        if (!h) return false;
        if (h.length < 1) return false;

        var strhref = h.toString().toLowerCase();
        var isvideo = false;
        if (strhref.indexOf(".mp4") > 0 ||
            strhref.indexOf(".wmv") > 0 ||
                strhref.indexOf(".wmx") > 0 ||
                    strhref.indexOf(".wvx") > 0 ||
                        strhref.indexOf(".ism") > 0 ||
                            strhref.indexOf("youtu") > 0 ||
                                strhref.indexOf(".flv") > 0 ||
                                    strhref.indexOf(".webm") > 0)
            return true;

        return false;
    });

    checkHtml5 = function (url) {

        var urlFormat = $.trim(url).split('.');
        var validHtml5 = false;
        for (var i = 0; i < urlFormat.length; i++) {
            if (urlFormat[i] === "mp4" || urlFormat[i] === "ogx" || urlFormat[i] === "webm") {
                validHtml5 = true;
            }
        }
        return validHtml5;
    }

    chtmObject = function (url, imagehref) {
        var vid = new Array();
        vid.push('<video style="" class="htm5videoplayer" id="playv" width="715" height="350"');
        vid.push(' poster="'+imagehref+'"');
        vid.push(' loop>');
        vid.push('<source src="' + url + '"  type="video/mp4" codecs="avc1.4D401E, mp4a.40.2" media="all"  />');
        vid.push('</video>');
        vid.push('<div class="pusedbutton"></div>');
        return vid.join("");
    };

    function html5Com(c) {
        var b = ['IE', 'Chrome', 'Safari', 'Firefox', 'Mobile'];
        var v = 9
        var a = false;
        if ($.inArray(c.b, b) != -1) {
            if (c.b === "IE") {
                if (c.v >= v) {
                    a = true;
                }
            } else {
                a = true;
            }
        }
        return a;
    }

    var BrowserType = function () {
        var b = "";
        var v = 0;
    };

    function isIE() {
        var rv = -1;
        if (navigator.appName == 'Microsoft Internet Explorer') {
            var ua = navigator.userAgent;
            var re = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
            if (re.exec(ua) != null)
                rv = parseFloat(RegExp.$1);
        }
        return { version: rv.toString() }
    };

    function detectBrowserVersion() {
        //mobile device list
        var m = ['android', 'iphone', 'ipad', 'ipod', 'mac', 'nokia', 'blackberry', 'linux', 'dopod', 'philips', 'lenovo', 'mot', 'samsung', 'sony', 'windows phone'];
        var a = navigator.userAgent.toLowerCase();
        // Is this a mobile device?
        var c = new BrowserType();
        for (var i = 0; i < m.length; i++) {
            if (a.indexOf(m[i]) != -1) {
                c.b = "Mobile";
            }
        }
        if (c.b != "Mobile") {
            $.browser.chrome = /chrome/.test(navigator.userAgent.toLowerCase());
            $.browser.msie = isIE();
            if ($.browser.msie.version >= 0) {
                a = $.browser.msie.version;
                c.v = a;
                c.b = "IE";
                $.browser.msie = true;
                return c;
            }
            // Is this a version of Chrome?
            if ($.browser.chrome) {
                a = a.substring(a.indexOf('chrome/') + 7);
                a = a.substring(0, a.indexOf('.'));
                c.v = a;
                // If it is chrome then jQuery thinks it's safari so we have to tell it it isn't
                $.browser.safari = false;
                c.b = "Chrome";
            }
            // Is this a version of Safari?
            if ($.browser.safari) {
                a = a.substring(a.indexOf('safari/') + 7);
                a = a.substring(0, a.indexOf('.'));
                c.v = a;
                c.b = "Safari";
            }
            // Is this a version of Mozilla?
            if ($.browser.mozilla) {
                //Is it Firefox?
                if (navigator.userAgent.toLowerCase().indexOf('firefox') != -1) {
                    a = a.substring(a.indexOf('firefox/') + 8);
                    a = a.substring(0, a.indexOf('.'));
                    c.v = a;
                    c.b = "Firefox";
                }
                    // If not then it must be another Mozilla
                else {
                }
            }
            // Is this a version of Opera?
            if ($.browser.opera) {
                a = a.substring(a.indexOf('version/') + 8);
                a = a.substring(0, a.indexOf('.'));
                c.v = a;
                c.b = "Opera";
            }

            if (typeof (c.b) == "undefined" && $.browser.mozilla && navigator.userAgent.toLowerCase().indexOf('11.0') != -1) {
                c.v = "11";
                c.b = "IE";
            }
        }
        return c;
    }


    var isok = function () {
        filter.each(function () {
            //$(this).removeAttr("target");
            var strhref = $(this).attr("href");
            var imagehref = $(this).attr("image");
            $(this).attr("href", "#");
            isHtml5 = checkHtml5(strhref);
            if (isHtml5) {
                var a = detectBrowserVersion();
                if (html5Com(a)) {
                    $("#video_Container").append(chtmObject(strhref, imagehref));
                    $("#playv").bind("click", function () {
                        var videoc = document.getElementById("playv");
                        var paused = videoc.paused;
                        if (paused) {
                            $(".pusedbutton").css("display", "none");
                            videoc.play();
                        } else {
                            videoc.pause();
                            $(".pusedbutton").css("display", "")
                        }
                        return false;
                    });
                    $(".pusedbutton").bind("click", function () {
                        var videoc = document.getElementById("playv");
                        videoc.play();
                        $(".pusedbutton").css("display", "none");
                    });
                    $(".htm5videoplayer").hover(function () {
                        $(".htm5videoplayer").attr("controls", "controls");
                    }, function () {
                        $(".htm5videoplayer").removeAttr("controls");
                    });

                } else {
                    $.creatvideo(strhref, imagehref);
                }
            } else {
                $.creatvideo(strhref, imagehref);
            }
            return false;
        });
    }
    var thePlayer;

    $.creatvideo = function (strhref, imagehref) {
        thePlayer = jwplayer('video_Container').setup({
            flashplayer: 'Content/isoftODC/player.swf',
            file: strhref,
            image: imagehref,
            width: 715,
            height: 350,
            dock: false
        });
    }
    /*judge the onload over*/
    var everyok = false;

    if (document.readyState == "complete") {
        if (!everyok) {
            isok();
        }
        everyok = true;
    }

    window.onload = function () {
        if (!everyok) {
            isok();
        }
        everyok = true;
    }
});