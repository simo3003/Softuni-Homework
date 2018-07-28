<?php

/* base.html.twig */
class __TwigTemplate_4bbe4cb00ce6f8d465c8dd6727bc2b9ec28634a7580dd9013cb65806d5629e1e extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'footer' => array($this, 'block_footer'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_aae423e7504dd9c6ab6f426366afde8be257dbb8fd4f1454e3427d568b93aac7 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_aae423e7504dd9c6ab6f426366afde8be257dbb8fd4f1454e3427d568b93aac7->enter($__internal_aae423e7504dd9c6ab6f426366afde8be257dbb8fd4f1454e3427d568b93aac7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_82148199c0aa50e46c863b4a65921c8018d87eb0d571aaab0667be605bfc8fda = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_82148199c0aa50e46c863b4a65921c8018d87eb0d571aaab0667be605bfc8fda->enter($__internal_82148199c0aa50e46c863b4a65921c8018d87eb0d571aaab0667be605bfc8fda_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 1
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 6
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 7
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 11
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 14
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 16
        $this->displayBlock('header', $context, $blocks);
        // line 34
        echo "
<div class=\"container body-container\">
    ";
        // line 36
        $this->displayBlock('body', $context, $blocks);
        // line 43
        echo "</div>

";
        // line 45
        $this->displayBlock('footer', $context, $blocks);
        // line 52
        echo "
";
        // line 53
        $this->displayBlock('javascripts', $context, $blocks);
        // line 59
        echo "
</body>
</html>
";
        
        $__internal_aae423e7504dd9c6ab6f426366afde8be257dbb8fd4f1454e3427d568b93aac7->leave($__internal_aae423e7504dd9c6ab6f426366afde8be257dbb8fd4f1454e3427d568b93aac7_prof);

        
        $__internal_82148199c0aa50e46c863b4a65921c8018d87eb0d571aaab0667be605bfc8fda->leave($__internal_82148199c0aa50e46c863b4a65921c8018d87eb0d571aaab0667be605bfc8fda_prof);

    }

    // line 6
    public function block_title($context, array $blocks = array())
    {
        $__internal_e7544ee0b6618f8196c3ab0bea2cd84eb49c3069f0cff509e2a75f6cbcfc018c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e7544ee0b6618f8196c3ab0bea2cd84eb49c3069f0cff509e2a75f6cbcfc018c->enter($__internal_e7544ee0b6618f8196c3ab0bea2cd84eb49c3069f0cff509e2a75f6cbcfc018c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_5e0a4dffdacb4143dca2249931f3912eac4932d916187184e662747ab3786be3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5e0a4dffdacb4143dca2249931f3912eac4932d916187184e662747ab3786be3->enter($__internal_5e0a4dffdacb4143dca2249931f3912eac4932d916187184e662747ab3786be3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_5e0a4dffdacb4143dca2249931f3912eac4932d916187184e662747ab3786be3->leave($__internal_5e0a4dffdacb4143dca2249931f3912eac4932d916187184e662747ab3786be3_prof);

        
        $__internal_e7544ee0b6618f8196c3ab0bea2cd84eb49c3069f0cff509e2a75f6cbcfc018c->leave($__internal_e7544ee0b6618f8196c3ab0bea2cd84eb49c3069f0cff509e2a75f6cbcfc018c_prof);

    }

    // line 7
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_3f39f3ffb0e24627dbac77027be3c925f09830f1571dfb21aa943256a70c4da2 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3f39f3ffb0e24627dbac77027be3c925f09830f1571dfb21aa943256a70c4da2->enter($__internal_3f39f3ffb0e24627dbac77027be3c925f09830f1571dfb21aa943256a70c4da2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_132be79246bd0a956d786977e9a7e56b80429f6e845c14f0a7b7c8ece4c1e094 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_132be79246bd0a956d786977e9a7e56b80429f6e845c14f0a7b7c8ece4c1e094->enter($__internal_132be79246bd0a956d786977e9a7e56b80429f6e845c14f0a7b7c8ece4c1e094_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 8
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 9
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_132be79246bd0a956d786977e9a7e56b80429f6e845c14f0a7b7c8ece4c1e094->leave($__internal_132be79246bd0a956d786977e9a7e56b80429f6e845c14f0a7b7c8ece4c1e094_prof);

        
        $__internal_3f39f3ffb0e24627dbac77027be3c925f09830f1571dfb21aa943256a70c4da2->leave($__internal_3f39f3ffb0e24627dbac77027be3c925f09830f1571dfb21aa943256a70c4da2_prof);

    }

    // line 14
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_204e16721dbbf00e5f2bc295f4da6e54c426cd07fe92b7cb11f57f1754c6663c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_204e16721dbbf00e5f2bc295f4da6e54c426cd07fe92b7cb11f57f1754c6663c->enter($__internal_204e16721dbbf00e5f2bc295f4da6e54c426cd07fe92b7cb11f57f1754c6663c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_b5041da5eccd8144e7935d07b6f5546baa57c39ee8993435bf6ce3ef35080175 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b5041da5eccd8144e7935d07b6f5546baa57c39ee8993435bf6ce3ef35080175->enter($__internal_b5041da5eccd8144e7935d07b6f5546baa57c39ee8993435bf6ce3ef35080175_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_b5041da5eccd8144e7935d07b6f5546baa57c39ee8993435bf6ce3ef35080175->leave($__internal_b5041da5eccd8144e7935d07b6f5546baa57c39ee8993435bf6ce3ef35080175_prof);

        
        $__internal_204e16721dbbf00e5f2bc295f4da6e54c426cd07fe92b7cb11f57f1754c6663c->leave($__internal_204e16721dbbf00e5f2bc295f4da6e54c426cd07fe92b7cb11f57f1754c6663c_prof);

    }

    // line 16
    public function block_header($context, array $blocks = array())
    {
        $__internal_fbabf8a483517143e2b2459c51272709e885e9894bc8ab8acd315f9a73495da0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_fbabf8a483517143e2b2459c51272709e885e9894bc8ab8acd315f9a73495da0->enter($__internal_fbabf8a483517143e2b2459c51272709e885e9894bc8ab8acd315f9a73495da0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        $__internal_c554d1f52ff653d09abb1b2d11414148012d38cf4179de3758f059241a9820fa = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c554d1f52ff653d09abb1b2d11414148012d38cf4179de3758f059241a9820fa->enter($__internal_c554d1f52ff653d09abb1b2d11414148012d38cf4179de3758f059241a9820fa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 17
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 21
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_c554d1f52ff653d09abb1b2d11414148012d38cf4179de3758f059241a9820fa->leave($__internal_c554d1f52ff653d09abb1b2d11414148012d38cf4179de3758f059241a9820fa_prof);

        
        $__internal_fbabf8a483517143e2b2459c51272709e885e9894bc8ab8acd315f9a73495da0->leave($__internal_fbabf8a483517143e2b2459c51272709e885e9894bc8ab8acd315f9a73495da0_prof);

    }

    // line 36
    public function block_body($context, array $blocks = array())
    {
        $__internal_b1276c3ff1dbdd7aac68624c0831ca533b259585f0cab02f15d60af758ad4e42 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b1276c3ff1dbdd7aac68624c0831ca533b259585f0cab02f15d60af758ad4e42->enter($__internal_b1276c3ff1dbdd7aac68624c0831ca533b259585f0cab02f15d60af758ad4e42_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_60b5338d1382ae4c0f1c8dc98a360e76fc7d79b69bdb173131564ac33176ca60 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_60b5338d1382ae4c0f1c8dc98a360e76fc7d79b69bdb173131564ac33176ca60->enter($__internal_60b5338d1382ae4c0f1c8dc98a360e76fc7d79b69bdb173131564ac33176ca60_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 37
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 39
        $this->displayBlock('main', $context, $blocks);
        // line 40
        echo "            </div>
        </div>
    ";
        
        $__internal_60b5338d1382ae4c0f1c8dc98a360e76fc7d79b69bdb173131564ac33176ca60->leave($__internal_60b5338d1382ae4c0f1c8dc98a360e76fc7d79b69bdb173131564ac33176ca60_prof);

        
        $__internal_b1276c3ff1dbdd7aac68624c0831ca533b259585f0cab02f15d60af758ad4e42->leave($__internal_b1276c3ff1dbdd7aac68624c0831ca533b259585f0cab02f15d60af758ad4e42_prof);

    }

    // line 39
    public function block_main($context, array $blocks = array())
    {
        $__internal_819cee800c702bbd32fcc2ea20f0bb9be62c136f184e982be0127db6c091d132 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_819cee800c702bbd32fcc2ea20f0bb9be62c136f184e982be0127db6c091d132->enter($__internal_819cee800c702bbd32fcc2ea20f0bb9be62c136f184e982be0127db6c091d132_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_d9e47ae8b2c277533c55f49c7821319eefa452771b84b728d376fb5d65fe7e53 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d9e47ae8b2c277533c55f49c7821319eefa452771b84b728d376fb5d65fe7e53->enter($__internal_d9e47ae8b2c277533c55f49c7821319eefa452771b84b728d376fb5d65fe7e53_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_d9e47ae8b2c277533c55f49c7821319eefa452771b84b728d376fb5d65fe7e53->leave($__internal_d9e47ae8b2c277533c55f49c7821319eefa452771b84b728d376fb5d65fe7e53_prof);

        
        $__internal_819cee800c702bbd32fcc2ea20f0bb9be62c136f184e982be0127db6c091d132->leave($__internal_819cee800c702bbd32fcc2ea20f0bb9be62c136f184e982be0127db6c091d132_prof);

    }

    // line 45
    public function block_footer($context, array $blocks = array())
    {
        $__internal_9b114a73005d7a3d029763fe99a7ec2854a036427259e0c2eae3663d3e98ba76 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_9b114a73005d7a3d029763fe99a7ec2854a036427259e0c2eae3663d3e98ba76->enter($__internal_9b114a73005d7a3d029763fe99a7ec2854a036427259e0c2eae3663d3e98ba76_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "footer"));

        $__internal_14218cafb2146c1e4ceeb1416ce7e5278a46bfd0fe40fe56866a4c69bbbe9476 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_14218cafb2146c1e4ceeb1416ce7e5278a46bfd0fe40fe56866a4c69bbbe9476->enter($__internal_14218cafb2146c1e4ceeb1416ce7e5278a46bfd0fe40fe56866a4c69bbbe9476_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "footer"));

        // line 46
        echo "    <footer>
        <div class=\"container modal-footer\">
           <p>&copy; Simo Aleksandrov - 2018</p>
        </div>
    </footer>
";
        
        $__internal_14218cafb2146c1e4ceeb1416ce7e5278a46bfd0fe40fe56866a4c69bbbe9476->leave($__internal_14218cafb2146c1e4ceeb1416ce7e5278a46bfd0fe40fe56866a4c69bbbe9476_prof);

        
        $__internal_9b114a73005d7a3d029763fe99a7ec2854a036427259e0c2eae3663d3e98ba76->leave($__internal_9b114a73005d7a3d029763fe99a7ec2854a036427259e0c2eae3663d3e98ba76_prof);

    }

    // line 53
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_ff7572fdff591c18f5fd0ccae74851aab1e21a009f3955366d5fb7eaccd9f903 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ff7572fdff591c18f5fd0ccae74851aab1e21a009f3955366d5fb7eaccd9f903->enter($__internal_ff7572fdff591c18f5fd0ccae74851aab1e21a009f3955366d5fb7eaccd9f903_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        $__internal_c9989eaf716a5383534845e42f7c372f04a029a59c90c5fdf551fceb238a4209 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c9989eaf716a5383534845e42f7c372f04a029a59c90c5fdf551fceb238a4209->enter($__internal_c9989eaf716a5383534845e42f7c372f04a029a59c90c5fdf551fceb238a4209_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 54
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 56
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 57
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_c9989eaf716a5383534845e42f7c372f04a029a59c90c5fdf551fceb238a4209->leave($__internal_c9989eaf716a5383534845e42f7c372f04a029a59c90c5fdf551fceb238a4209_prof);

        
        $__internal_ff7572fdff591c18f5fd0ccae74851aab1e21a009f3955366d5fb7eaccd9f903->leave($__internal_ff7572fdff591c18f5fd0ccae74851aab1e21a009f3955366d5fb7eaccd9f903_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  279 => 57,  275 => 56,  271 => 55,  266 => 54,  257 => 53,  242 => 46,  233 => 45,  216 => 39,  204 => 40,  202 => 39,  198 => 37,  189 => 36,  166 => 21,  160 => 17,  151 => 16,  134 => 14,  122 => 9,  117 => 8,  108 => 7,  90 => 6,  77 => 59,  75 => 53,  72 => 52,  70 => 45,  66 => 43,  64 => 36,  60 => 34,  58 => 16,  53 => 14,  46 => 11,  44 => 7,  40 => 6,  33 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>

{% block footer %}
    <footer>
        <div class=\"container modal-footer\">
           <p>&copy; Simo Aleksandrov - 2018</p>
        </div>
    </footer>
{% endblock %}

{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
", "base.html.twig", "D:\\Homework\\Softuni\\Tech-Module-May-2018\\Software-Technologies-July-2018\\Calculator-PHP\\app\\Resources\\views\\base.html.twig");
    }
}
