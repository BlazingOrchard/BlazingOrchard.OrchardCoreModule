using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.BlazingOrchardTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineScript("BlazingOrchardTheme-vendor-jQuery")
                .SetUrl("~/BlazingOrchardTheme/vendor/jquery/jquery.min.js", "~/BlazingOrchardTheme/vendor/jquery/jquery.js")
                .SetCdn("https://code.jquery.com/jquery-3.5.1.min.js", "https://code.jquery.com/jquery-3.5.1.js")
                .SetCdnIntegrity("sha384-ZvpUoO/+PpLXR1lu4jmpXWu80pZlYUAfxl5NsBMWOEPSjUn/6Z/hRTt8+pR6L4N2", "sha384-/LjQZzcpTzaYn7qWqRIWYC5l8FWEZ2bIHIz0D73Uzba4pShEcdLdZyZkI4Kv676E")
                .SetVersion("3.5.1");

            manifest
                .DefineScript("BlazingOrchardTheme-vendor-jQuery.slim")
                .SetUrl("~/BlazingOrchardTheme/vendor/jquery/jquery.slim.min.js", "~/BlazingOrchardTheme/vendor/jquery/jquery.slim.js")
                .SetCdn("https://code.jquery.com/jquery-3.5.1.slim.min.js", "https://code.jquery.com/jquery-3.5.1.slim.js")
                .SetCdnIntegrity("sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj", "sha384-x6NENSfxadikq2gB4e6/qompriNc+y1J3eqWg3hAAMNBs4dFU303XMTcU3uExJgZ")
                .SetVersion("3.5.1");


            manifest
                .DefineScript("BlazingOrchardTheme-vendor-bootstrap")
                .SetDependencies("BlazingOrchardTheme-vendor-jQuery")
                .SetUrl("~/BlazingOrchardTheme/vendor/bootstrap/js/bootstrap.min.js", "~/BlazingOrchardTheme/vendor/bootstrap/js/bootstrap.js")
                .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js", "https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.js")
                .SetCdnIntegrity("sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI", "sha384-7emZq+z4THDbp1s8SKlmK0zlENQgT+twJBBAcJCe8c+mastOWEfHflsBcz9t1ste")
                .SetVersion("4.5.0");

            manifest
                .DefineScript("BlazingOrchardTheme-vendor-bootstrap-bundle")
                .SetDependencies("BlazingOrchardTheme-vendor-jQuery")
                .SetUrl("~/BlazingOrchardTheme/vendor/bootstrap/js/bootstrap.bundle.min.js", "~/BlazingOrchardTheme/vendor/bootstrap/js/bootstrap.bundle.js")
                .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js", "https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.js")
                .SetCdnIntegrity("sha384-1CmrxMRARb6aLqgBO7yyAxTOQE2AKb9GfXnEo760AUcUmFx3ibVJJAzGytlQcNXd", "sha384-cCFlyGmw6CL62KEUKL7PWDyTOf28usI04ep/5Re2w+M71E1K/sPaE0az/Zj17YG0")
                .SetVersion("4.5.0");

            manifest
                .DefineStyle("BlazingOrchardTheme-vendor-bootstrap")
                .SetUrl("~/BlazingOrchardTheme/vendor/bootstrap/css/bootstrap.min.css", "~/BlazingOrchardTheme/vendor/bootstrap/css/bootstrap.css")
                .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css", "https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.css")
                .SetCdnIntegrity("sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk", "sha384-BHMmCeZEB8FFTwXRrSSWZJd7NXU/Hh4EawgpQO+3MDzE/GMYgbXgHb8ylJcUlBeK")
                .SetVersion("4.5.0");

            manifest
                .DefineStyle("BlazingOrchardTheme-bootstrap-oc")
                .SetUrl("~/BlazingOrchardTheme/css/bootstrap-oc.min.css", "~/BlazingOrchardTheme/css/bootstrap-oc.css")
                .SetVersion("1.0.0");

            manifest
                .DefineStyle("BlazingOrchardTheme-vendor-font-awesome")
                .SetUrl("~/BlazingOrchardTheme/vendor/fontawesome-free/css/all.min.css", "~/BlazingOrchardTheme/vendor/fontawesome-free/css/all.css")
                .SetCdn("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/css/all.min.css", "https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/css/all.css")
                .SetCdnIntegrity("sha384-Bfad6CLCknfcloXFOyFnlgtENryhrpZCe29RTifKEixXQZ38WheV+i/6YWSzkz3V", "sha384-I4s88/QBf6OKVFMRRyjRY9wYdRoEO/PnNLQ1xY+G0OQfntKp8FxRsOg9qjmtbnvL")
                .SetVersion("5.13.0");

            manifest
                .DefineScript("BlazingOrchardTheme-vendor-font-awesome")
                .SetCdn("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/js/all.min.js", "https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/js/all.js")
                .SetCdnIntegrity("sha384-ujbKXb9V3HdK7jcWL6kHL1c+2Lj4MR4Gkjl7UtwpSHg/ClpViddK9TI7yU53frPN", "sha384-Z4FE6Znluj29FL1tQBLSSjn1Pr72aJzuelbmGmqSAFTeFd42hQ4WHTc0JC30kbQi")
                .SetVersion("5.13.0");
        }
    }
}
