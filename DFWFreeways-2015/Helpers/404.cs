//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace DFWFreeways.Helpers
//{
//    public class _404
//    {
//    }






//    using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Collections;

//public partial class _404 : System.Web.UI.Page
//{
//    protected void Page_Load(object sender, EventArgs e)
//    {


//        //if the request has a querystring for aspxerrorpath, use it to obtain the original requested URL.
//        //If there is no querystring, there should be a semicolon separating the URL for this page from the original requested URL
//        string originalUrl = "";
 
        
//        string requestedURLServer = Request.Url.GetLeftPart(UriPartial.Authority); // may not have port number
//        if (Request.QueryString["aspxerrorpath"] != null && !String.IsNullOrEmpty(Request.QueryString["aspxerrorpath"]))
//        {
//            originalUrl = Request.QueryString["aspxerrorpath"].ToString();
//        }
//        else
//        {
//            string rawUrl = "";
//            string[] parts = Request.RawUrl.Split(';');
//            if (parts.Length > 1)
//                rawUrl = parts[parts.Length - 1];
//            if (!String.IsNullOrEmpty(rawUrl))
//            {
//                //need to remove the server portion of the URL
//                 //Strip out the server part of the URL
//                originalUrl = rawUrl.Replace(requestedURLServer, "");
//                //if the remaining string has the port number at the beginning, strip it off and add it to the requestedURLServer
//                string port = "";
//                if (originalUrl.IndexOf(':') == 0)
//                {
//                    port = originalUrl.Substring(0, originalUrl.IndexOf('/'));
//                    originalUrl = originalUrl.Substring(originalUrl.IndexOf('/'));
//                    //requestedURLServer += port;
//                }

//            }

//        }


//        //This is for troubleshooting and should normally be commented out
//        displayInfo.Text = "Request.RawUrl: " + Request.RawUrl;
//        displayInfo2.Text = "Request.Url.Authority: " + requestedURLServer;
//        displayInfo3.Text = "originalUrl: " + originalUrl;
//        displayInfo4.Text = "";
//        displayInfo5.Text = "";
//        displayInfo6.Text = "";
//        displayInfo7.Text = "";
         
//        //return;

//        //convert originalUrl to lower case to prevent case mismatches
//        originalUrl = originalUrl.ToLower();

//        //If originalUrl is /404.aspx , then there is a malfunction. Redirect to the home page
//        if (originalUrl.Contains("404.aspx"))
//        {
//            if (Request.Cookies["siteId"] == null)
//                SetSiteCookie(11);
//            Redirect301("/default.aspx");
//        }

//        else if (String.IsNullOrEmpty(originalUrl))
//        {

//            //redirect to home11 home page
//            SetSiteCookie(11);
//            Redirect301("/default.aspx");
//        }

//        //Home10 requests
//        else if (originalUrl.Contains("home10"))
//        {
//            string redirectTo = "";
//            //I don't know if this if block is really needed
//            if (originalUrl == "/home10" || originalUrl == "/home10/")
//                redirectTo = requestedURLServer;
//            else
//                redirectTo = requestedURLServer + originalUrl.Replace("/home10", "");

//            SetSiteCookie(10);
//            //displayInfo4.Text = "Inside home10 redirect, redirect to: " + redirectTo;
//            //return;
//            Redirect301(redirectTo);
//        }


//        //if the url has "term-life" in it, assume this is an invalid url for home9. Redirect to the home9 root
//        //ALERT: the trailing slash on "term-life/" is needed to avoid picking up URLs like webchat.selectquote.com/home9/jsp/term-life-insurance.html?refid=26
//        else if (originalUrl.Contains("term-life/"))
//        {

//            Redirect301("/term-life/insurance/");
//        }


//        else if (originalUrl.Contains("home11"))
//        {
//            string redirectTo = "";
//            //I don't know if this if block is really needed
//            if (originalUrl == "/home11" || originalUrl == "/home11/")
//                redirectTo = requestedURLServer;
//            else
//                redirectTo = requestedURLServer + originalUrl.Replace("/home11", "");

//            //Do not set the site cookie to 11 if the site cookie is currently set to 12
//            //Set the site cookie to 11 if it is null
//            if ((Request.Cookies["siteId"] != null && Request.Cookies["siteId"].ToString() != "12") || (Request.Cookies["siteId"] == null) )
//                SetSiteCookie(11);

//            Redirect301(redirectTo);
//        }

        
//        else if (originalUrl.Contains("home9"))
//        {
//            SetSiteCookie(11);
//                //displayInfo6.Text = "inside else block for originalUrl contains home9, redirectTo = " + redirectTo;
//                //return;
//            Redirect301(MapHome9(requestedURLServer, originalUrl));
//        }


//        else if (originalUrl.Contains("home12") )
//        {
//            SetSiteCookie(12);
//            Redirect301(requestedURLServer + originalUrl.Replace("/home12", "/"));
//        }

//        else if (originalUrl.Contains("home2"))
//        {
//            SetSiteCookie(11);
//            Dictionary<string, string> Home2ToHome11 = CreateMappingDictionary();
//            if (Home2ToHome11.ContainsKey(originalUrl))
//            {
//                Redirect301(requestedURLServer + Home2ToHome11[originalUrl]);  //Note that Response.Redirect uses code 302, and code 301 is desired
//            }
//            else
//            {
//                Redirect301(requestedURLServer + "/default.aspx");
//            }

//        }

//        //if the url starts with "/chinese" then it needs to be redirected to the chinese directory under the term-life application root
//        else if (originalUrl.Substring(0, 8).ToLower() == "/chinese")
//        {
//            Redirect301(requestedURLServer + "/term-life" + originalUrl);
//        }
//        else
//        {

//            //The page was not found
//            displayInfo8.Text = "About to redirect to Error.htm. OriginalUrl: " + originalUrl;
//            //return;

//            //use a regular response.redirect (code 300) here since this redirect is not necessarily permanent. (For example, a page matching the invalid URL could be created in the future.)
//            Response.Redirect("/Error.htm");

//        }

//    }

//    private void SetSiteCookie(int siteId)
//    {
//        if (Request.Cookies["siteId"] == null)
//            Response.Cookies.Add(new HttpCookie("siteId", siteId.ToString()));
//        else
//            Response.Cookies["siteId"].Value = siteId.ToString();
//    }


//    //This method checks if the requested URL is a Home2 URL which is mapped to Home11
//    private Dictionary<string, string> CreateMappingDictionary()
//    {
//        Dictionary<string, string> Home2ToHome11 = new System.Collections.Generic.Dictionary<string, string>();

//        Home2ToHome11.Add("home2/homepage.html", "home11/");
//        Home2ToHome11.Add("/home2/info/advantage/save.html", "/HowWeHelp.aspx");
//        Home2ToHome11.Add("/home2/info/advantage/truth.html", "/AboutQuotes.aspx");
//        Home2ToHome11.Add("/home2/info/advantage/start.html", "/GetStarted.aspx");
//        Home2ToHome11.Add("/home2/info/advantage/advantage.html", "/learning/why_selectquote.aspx");
//        Home2ToHome11.Add("/home2/info/company/phone.html", "/GetStarted.aspx");
//        Home2ToHome11.Add("/home2/form/quote/quotestep1.ssq", "/ready/Default.aspx?ref=int");
//        Home2ToHome11.Add("/home2/info/carriers/carriers.html", "/about/our_carriers.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/amay_fcol.html", "/carriers/genworth_financial.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/uomh.html", "/carriers/united_of_omaha_life_insurance_company.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/pruc_prny.html", "/carriers/pruco_life_insurance_company.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/amgn.html", "/carriers/american_general_life_companies.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/banr.html", "/carriers/banner_life_insurance_company.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/wpen.html", "/carriers/william_penn_life_insurance_company.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/wcli.html", "/carriers/west_coast_life_insurance_company.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/ing.html", "/carriers/reliastar_life_insurance_company.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/fidy.html", "/carriers/fidelity_life_association.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/transAmerica.html", "/carriers/transamerica_life_insurance_company.aspx");
//        Home2ToHome11.Add("/home2/info/company/faq.html", "/learning/faq.aspx");
//        Home2ToHome11.Add("/home2/info/company/privacy.html", "/privacy.aspx");
//        Home2ToHome11.Add("/home2/info/company/contact.html", "/contact.aspx");
//        Home2ToHome11.Add("/home2/form/help/helpform.ssq", "/contact.aspx");
//        Home2ToHome11.Add("/home2/info/company/careers.html", "/about/careers.aspx");
//        Home2ToHome11.Add("/home2/info/misc/what_selectquote_sell.html", "/learning/");
//        Home2ToHome11.Add("/home2/info/misc/sell_insurance_outside.html", "/learning/");
//        //Home2ToHome11.Add("/chinese/simplified/index.html", "/chinese/");
//        //Home2ToHome11.Add("/chinese/simplified/compare-term-perm.html", "/chinese/");
//        //Home2ToHome11.Add("/chinese/simplified/save.html", "/chinese/");
//        //Home2ToHome11.Add("/chinese/simplified/truth.html", "/chinese/");
//        //Home2ToHome11.Add("/chinese/simplified/top-ten-questions.html", "/chinese/");
//        //Home2ToHome11.Add("/chinese/simplified/start.html", "/chinese/");
//        Home2ToHome11.Add("/home2/info/advantage/types.html", "/learning/");
//        Home2ToHome11.Add("/home2/info/advantage/testimonials.html", "/testimonials.aspx");
//        Home2ToHome11.Add("/home2/info/company/legal.html", "/legal.aspx");
//        Home2ToHome11.Add("/home2/info/product/list.html", "/about/our_carriers.aspx");
//        Home2ToHome11.Add("/home2/info/company/sitemap.html", "/");
//        Home2ToHome11.Add("/home2/info/company/commercials.html", "/advertising_disclaimers.aspx");
//        Home2ToHome11.Add("/home2/form/quote/quotestep2.ssq", "/ready/Default.aspx?ref=int");
//        Home2ToHome11.Add("/home2/form/quote/quotestep3.ssq", "/ready/Default.aspx?ref=int");
//        Home2ToHome11.Add("/home2/form/quote/quotestep4.ssq", "/ready/Default.aspx?ref=int");
//        Home2ToHome11.Add("/home2/form/quote/quotestep5.ssq", "/ready/Default.aspx?ref=int");
//        Home2ToHome11.Add("/home2/info/misc/tell_me_more.html", "/about/");
//        Home2ToHome11.Add("/home2/info/misc/privacy.html", "/privacy.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/fedk.html", "/about/our_carriers.aspx");
//        Home2ToHome11.Add("/home2/info/carriers/emgn.html", "/about/our_carriers.aspx");
//        Home2ToHome11.Add("/home2/info/product/West Coast Life Insurance Company - West Coast Life Focus Term 30_P2885.html", "/carriers/west_coast_life_insurance_company.aspx");
//        return Home2ToHome11;

//    }

//    private void Redirect301(string destination)
//    {
//        Response.Clear();
//        Response.StatusCode = 301;
//        Response.StatusDescription = "Moved Permanently";
//        Response.AddHeader("Location", destination);
//    }

    
//    //This procedure sets the siteId cookie after Response.Clear(). However, this should not be needed because Response.Clear() theoretically should not clear cookies.
//    private void Redirect301WithSiteIdCookie(string destination, int siteId)
//    {
//        Response.Clear();
//        SetSiteCookie(siteId);
//        Response.StatusCode = 301;
//        Response.StatusDescription = "Moved Permanently";
//        Response.AddHeader("Location", destination);
//    }


//    private string MapHome9(string requestedURLServer, string originalUrl)
//    {
//        displayInfo4.Text = "Inside MapHome9";
//        //if originalUrl is blank, redirect to the home page
//        if (String.IsNullOrEmpty(originalUrl))
//        {
//            //redirect to home9 home page
//            return "term-life/insurance/home9_t3.aspx";
//        }
//        else
//        {
//            //extract any querystring from the original URL
//            string[] qsSplit = originalUrl.Split('?');
//            string qs = "";
//            string originalUrlWithoutQueryString = originalUrl;
//            if (((ICollection)qsSplit).Count > 1)
//            { //I don't know why, but I needed to cast to ICollection
//                qs = qsSplit[1];
//                originalUrlWithoutQueryString = qsSplit[0];
//            }

//            displayInfo5.Text = "qs: " + qs;

//            //first replace "/home9" with "/term-life" and "/jsp" with "/insurance"
//            string originalUrlWithoutQueryStringUpdated = originalUrlWithoutQueryString.Replace("/home9", "/term-life").Replace("/jsp", "/insurance");

//            Dictionary<string, string> mappingDictionary = Home9CreateMappingDictionary();
//            if (mappingDictionary.ContainsKey(originalUrlWithoutQueryStringUpdated))
//            {
//                //displayInfo6.Text = "redirect to: " + requestedURLServer + Home2ToHome11[originalUrlWithoutQueryString] + ((!String.IsNullOrEmpty(qs)) ? "?" + qs : "");
//                //return;

//                if (String.IsNullOrEmpty(requestedURLServer))
//                    //do not include home9 in the path
//                    return mappingDictionary[originalUrlWithoutQueryStringUpdated] + ((!String.IsNullOrEmpty(qs)) ? "?" + qs : "");  
//                else
//                    //build the full path
//                    return requestedURLServer + mappingDictionary[originalUrlWithoutQueryStringUpdated] + ((!String.IsNullOrEmpty(qs)) ? "?" + qs : "");  
//            }
//            else
//            {
//                displayInfo5.Text = "Else block";

//                //redirect to originalUrlWithoutQueryStringUpdated. If it turns out to be invalid, it will get picked up by the 404.aspx in the home9 directory
//                if (String.IsNullOrEmpty(requestedURLServer))
//                    //do not include home9 in the path
//                    return originalUrlWithoutQueryStringUpdated + ((!String.IsNullOrEmpty(qs)) ? "?" + qs : "");
//                else
//                    //build the full path
//                    return requestedURLServer + originalUrlWithoutQueryStringUpdated + ((!String.IsNullOrEmpty(qs)) ? "?" + qs : "");  

//            }
//        }
//    }

//    //This method checks if the requested URL is a Home2 URL which is mapped to Home11
//    private Dictionary<string, string> Home9CreateMappingDictionary()
//    {
//        Dictionary<string, string> Home9OldToNew = new System.Collections.Generic.Dictionary<string, string>();

//        //Map to existing page in new site
//        Home9OldToNew.Add("/term-life/insurance/home9_t3.ssq", "/term-life/insurance/home9_t3.aspx");
//        Home9OldToNew.Add("/term-life/insurance/home.jsp", "/term-life/insurance/home9_t3.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_5_8_dontWasteMoney.jsp", "/term-life/insurance/topic_5_8_dontWasteMoney.html");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_6_buying.jsp", "/term-life/insurance/topic_10_6_buying.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_8_28_careers.jsp", "/term-life/insurance/topic_8_28_careers.html");
//        Home9OldToNew.Add("/term-life/insurance/topic_2_1_quoteEstimate.jsp", "/term-life/insurance/topic_2_1_quoteEstimate.html");
//        Home9OldToNew.Add("/term-life/insurance/topic_3_9_securingRate.jsp", "/term-life/insurance/topic_3_9_securingRate.html");
//        Home9OldToNew.Add("/term-life/insurance/topic_2_3_misleadingQuote.jsp", "/term-life/insurance/topic_2_3_misleadingQuote.html");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_3_variationsTerm.jsp", "/term-life/insurance/topic_10_3_variationsTerm.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_8_29_commercial.jsp", "/term-life/insurance/topic_8_29_commercial.html");
//        Home9OldToNew.Add("/term-life/insurance/topic_8_2_whatClientsSay.jsp", "/term-life/insurance/topic_8_2_whatClientsSay.html");
//        Home9OldToNew.Add("/term-life/insurance/topic_4_3_glossary.jsp", "/term-life/insurance/topic_4_3_glossary.html");
//        Home9OldToNew.Add("/term-life/insurance/term-life-quote.html", "/term-life/insurance/form/quote/quotestep1.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_4_1_top10Questions.jsp", "/term-life/insurance/topic_4_1_top10Questions.html");
//        Home9OldToNew.Add("/term-life/insurance/insurance-for-dummies.html", "/term-life/insurance/insurance-for-dummies.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_1_wrongWay.html", "/term-life/insurance/topic_10_1_wrongWay.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_2_rightWay.html", "/term-life/insurance/topic_10_2_rightWay.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_3_variationsTerm.html", "/term-life/insurance/topic_10_3_variationsTerm.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_4_makingChoice.html", "/term-life/insurance/topic_10_4_makingChoice.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_5_debunkingMyths.html", "/term-life/insurance/topic_10_5_debunkingMyths.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_6_buying.html", "/term-life/insurance/topic_10_6_buying.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_7_whoDoesDoesntNeed.html", "/term-life/insurance/topic_10_7_whoDoesDoesntNeed.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_9_howMuchCoverage.html", "/term-life/insurance/topic_10_9_howMuchCoverage.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_10_buyingMore.html", "/term-life/insurance/topic_10_10_buyingMore.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_11_commissions.html", "/term-life/insurance/topic_10_11_commissions.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_12_homemakers.html", "/term-life/insurance/topic_10_12_homemakers.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_13_choosingStrong.html", "/term-life/insurance/topic_10_13_choosingStrong.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_14_newParent.html", "/term-life/insurance/topic_10_14_newParent.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_15_divorcing.html", "/term-life/insurance/topic_10_15_divorcing.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_16_dying.html", "/term-life/insurance/topic_10_16_dying.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_18_relationships.html", "/term-life/insurance/topic_10_18_relationships.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_19_speakingLanguage.html", "/term-life/insurance/topic_10_19_speakingLanguage.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_20_variationsPermanent.html", "/term-life/insurance/topic_10_20_variationsPermanent.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_21_supplementalMyth.html", "/term-life/insurance/topic_10_21_supplementalMyth.aspx");
//        Home9OldToNew.Add("/term-life/insurance/topic_10_22_pricing.html", "/term-life/insurance/topic_10_22_pricing.aspx");

//        //Page does not exist in new site. Map to similar page
//        Home9OldToNew.Add("/term-life/insurance/topic_12_1_ned.jsp", "/term-life/insurance/selectquote-advantage.html");
//        Home9OldToNew.Add("/term-life/insurance/commercials.html", "/term-life/insurance/selectquote-advantage.html");
//        Home9OldToNew.Add("/term-life/insurance/topic_12_3_hard.html", "/term-life/insurance/selectquote-advantage.html");
//        Home9OldToNew.Add("/term-life/insurance/topic_12_2_dana.html", "/term-life/insurance/selectquote-advantage.html");
//        Home9OldToNew.Add("/term-life/insurance/hub2.jsp", "/term-life/insurance/home9_t3.aspx");
//        Home9OldToNew.Add("/term-life/insurance/hub7.jsp", "/term-life/insurance/home9_t3.aspx");
//        Home9OldToNew.Add("/term-life/insurance/info/product/list.chmtl", "/term-life/insurance/term-life-insurance-companies.html");
//        Home9OldToNew.Add("/term-life/insurance/term-life-insurance.html", "/term-life/insurance/home9_t3.aspx");
//        //video
//        Home9OldToNew.Add("/term-life/insurance/topic_9_1-9_suzeVideo.asp", "/term-life/insurance/topic_9_1-9_suzeVideo.aspx");

//        return Home9OldToNew;

//    }
//}






//}