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
        $__internal_095d9d205161f0a5fa90124117f438e07480a348ae8059d385b173deac56330a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_095d9d205161f0a5fa90124117f438e07480a348ae8059d385b173deac56330a->enter($__internal_095d9d205161f0a5fa90124117f438e07480a348ae8059d385b173deac56330a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_9630d6a2a0c4964fb415008c966f8b69924fb87dbd002cb52a1b476550d2e23e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9630d6a2a0c4964fb415008c966f8b69924fb87dbd002cb52a1b476550d2e23e->enter($__internal_9630d6a2a0c4964fb415008c966f8b69924fb87dbd002cb52a1b476550d2e23e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

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
        
        $__internal_095d9d205161f0a5fa90124117f438e07480a348ae8059d385b173deac56330a->leave($__internal_095d9d205161f0a5fa90124117f438e07480a348ae8059d385b173deac56330a_prof);

        
        $__internal_9630d6a2a0c4964fb415008c966f8b69924fb87dbd002cb52a1b476550d2e23e->leave($__internal_9630d6a2a0c4964fb415008c966f8b69924fb87dbd002cb52a1b476550d2e23e_prof);

    }

    // line 6
    public function block_title($context, array $blocks = array())
    {
        $__internal_33de9b4dfa124e085cc8ccc26c3c04fa9b1644b386126b9f91c8797875e61b5a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_33de9b4dfa124e085cc8ccc26c3c04fa9b1644b386126b9f91c8797875e61b5a->enter($__internal_33de9b4dfa124e085cc8ccc26c3c04fa9b1644b386126b9f91c8797875e61b5a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_09d936e315b8e33501a80deeea61372239fe33460999f51c11c880886d87324e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_09d936e315b8e33501a80deeea61372239fe33460999f51c11c880886d87324e->enter($__internal_09d936e315b8e33501a80deeea61372239fe33460999f51c11c880886d87324e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_09d936e315b8e33501a80deeea61372239fe33460999f51c11c880886d87324e->leave($__internal_09d936e315b8e33501a80deeea61372239fe33460999f51c11c880886d87324e_prof);

        
        $__internal_33de9b4dfa124e085cc8ccc26c3c04fa9b1644b386126b9f91c8797875e61b5a->leave($__internal_33de9b4dfa124e085cc8ccc26c3c04fa9b1644b386126b9f91c8797875e61b5a_prof);

    }

    // line 7
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_a5608f2b8a6e0101d85b31869a157108c1e4e232f866bc3784bf86d9ac2a31fb = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a5608f2b8a6e0101d85b31869a157108c1e4e232f866bc3784bf86d9ac2a31fb->enter($__internal_a5608f2b8a6e0101d85b31869a157108c1e4e232f866bc3784bf86d9ac2a31fb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_6334a627a6a58e0014917a92f7ef27fff7f77b037b81de99ec7e7aa5b0c9cb55 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6334a627a6a58e0014917a92f7ef27fff7f77b037b81de99ec7e7aa5b0c9cb55->enter($__internal_6334a627a6a58e0014917a92f7ef27fff7f77b037b81de99ec7e7aa5b0c9cb55_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 8
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 9
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_6334a627a6a58e0014917a92f7ef27fff7f77b037b81de99ec7e7aa5b0c9cb55->leave($__internal_6334a627a6a58e0014917a92f7ef27fff7f77b037b81de99ec7e7aa5b0c9cb55_prof);

        
        $__internal_a5608f2b8a6e0101d85b31869a157108c1e4e232f866bc3784bf86d9ac2a31fb->leave($__internal_a5608f2b8a6e0101d85b31869a157108c1e4e232f866bc3784bf86d9ac2a31fb_prof);

    }

    // line 14
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_afcb51d90f156d39635641caa4f3a62ea6a95b22f9ada092b89d46c62d3467f1 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_afcb51d90f156d39635641caa4f3a62ea6a95b22f9ada092b89d46c62d3467f1->enter($__internal_afcb51d90f156d39635641caa4f3a62ea6a95b22f9ada092b89d46c62d3467f1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_0dcf6a93a354950e044958eea27540df54693215db78b44d62583838f91e1a04 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0dcf6a93a354950e044958eea27540df54693215db78b44d62583838f91e1a04->enter($__internal_0dcf6a93a354950e044958eea27540df54693215db78b44d62583838f91e1a04_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_0dcf6a93a354950e044958eea27540df54693215db78b44d62583838f91e1a04->leave($__internal_0dcf6a93a354950e044958eea27540df54693215db78b44d62583838f91e1a04_prof);

        
        $__internal_afcb51d90f156d39635641caa4f3a62ea6a95b22f9ada092b89d46c62d3467f1->leave($__internal_afcb51d90f156d39635641caa4f3a62ea6a95b22f9ada092b89d46c62d3467f1_prof);

    }

    // line 16
    public function block_header($context, array $blocks = array())
    {
        $__internal_8236d29cce704d6abbaf1e0a66a103f8d18b72aa817e2d91d9af490acdc900aa = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8236d29cce704d6abbaf1e0a66a103f8d18b72aa817e2d91d9af490acdc900aa->enter($__internal_8236d29cce704d6abbaf1e0a66a103f8d18b72aa817e2d91d9af490acdc900aa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        $__internal_8259df7dab8863ac3739b8ad7af7a8af9ae7c564d68b5735b22f1d230879c6b9 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8259df7dab8863ac3739b8ad7af7a8af9ae7c564d68b5735b22f1d230879c6b9->enter($__internal_8259df7dab8863ac3739b8ad7af7a8af9ae7c564d68b5735b22f1d230879c6b9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

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
        
        $__internal_8259df7dab8863ac3739b8ad7af7a8af9ae7c564d68b5735b22f1d230879c6b9->leave($__internal_8259df7dab8863ac3739b8ad7af7a8af9ae7c564d68b5735b22f1d230879c6b9_prof);

        
        $__internal_8236d29cce704d6abbaf1e0a66a103f8d18b72aa817e2d91d9af490acdc900aa->leave($__internal_8236d29cce704d6abbaf1e0a66a103f8d18b72aa817e2d91d9af490acdc900aa_prof);

    }

    // line 36
    public function block_body($context, array $blocks = array())
    {
        $__internal_2b68f671cb78644a29ef65c978c542daa8290355308e3d5ae5e86b6bfe735abc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2b68f671cb78644a29ef65c978c542daa8290355308e3d5ae5e86b6bfe735abc->enter($__internal_2b68f671cb78644a29ef65c978c542daa8290355308e3d5ae5e86b6bfe735abc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_42e98cc36cff72c3b6bf0b556c2288832c1fa171ca3c7b1d9838e7c4857cdbcc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_42e98cc36cff72c3b6bf0b556c2288832c1fa171ca3c7b1d9838e7c4857cdbcc->enter($__internal_42e98cc36cff72c3b6bf0b556c2288832c1fa171ca3c7b1d9838e7c4857cdbcc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

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
        
        $__internal_42e98cc36cff72c3b6bf0b556c2288832c1fa171ca3c7b1d9838e7c4857cdbcc->leave($__internal_42e98cc36cff72c3b6bf0b556c2288832c1fa171ca3c7b1d9838e7c4857cdbcc_prof);

        
        $__internal_2b68f671cb78644a29ef65c978c542daa8290355308e3d5ae5e86b6bfe735abc->leave($__internal_2b68f671cb78644a29ef65c978c542daa8290355308e3d5ae5e86b6bfe735abc_prof);

    }

    // line 39
    public function block_main($context, array $blocks = array())
    {
        $__internal_701a30d34cdbd015e4cbee6a24b5cb208b19a4926658258e33ef0952184074c6 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_701a30d34cdbd015e4cbee6a24b5cb208b19a4926658258e33ef0952184074c6->enter($__internal_701a30d34cdbd015e4cbee6a24b5cb208b19a4926658258e33ef0952184074c6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_63fbd302b5f0cbc1e947d1d4fe482c01ac16f7832440605b0c43f8d06809b777 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_63fbd302b5f0cbc1e947d1d4fe482c01ac16f7832440605b0c43f8d06809b777->enter($__internal_63fbd302b5f0cbc1e947d1d4fe482c01ac16f7832440605b0c43f8d06809b777_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_63fbd302b5f0cbc1e947d1d4fe482c01ac16f7832440605b0c43f8d06809b777->leave($__internal_63fbd302b5f0cbc1e947d1d4fe482c01ac16f7832440605b0c43f8d06809b777_prof);

        
        $__internal_701a30d34cdbd015e4cbee6a24b5cb208b19a4926658258e33ef0952184074c6->leave($__internal_701a30d34cdbd015e4cbee6a24b5cb208b19a4926658258e33ef0952184074c6_prof);

    }

    // line 45
    public function block_footer($context, array $blocks = array())
    {
        $__internal_14f43d82d0f725f02141ba1da9d034cc093ba56b08b11a54121431ada7f9bb33 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_14f43d82d0f725f02141ba1da9d034cc093ba56b08b11a54121431ada7f9bb33->enter($__internal_14f43d82d0f725f02141ba1da9d034cc093ba56b08b11a54121431ada7f9bb33_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "footer"));

        $__internal_b7d30c3c7b277dd26d75a50f905e205f53037ddf6e77bdf080347f27fe035710 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b7d30c3c7b277dd26d75a50f905e205f53037ddf6e77bdf080347f27fe035710->enter($__internal_b7d30c3c7b277dd26d75a50f905e205f53037ddf6e77bdf080347f27fe035710_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "footer"));

        // line 46
        echo "    <footer>
        <div class=\"container modal-footer\">
            <p>&copy; 2018 - Software University Foundation</p>
        </div>
    </footer>
";
        
        $__internal_b7d30c3c7b277dd26d75a50f905e205f53037ddf6e77bdf080347f27fe035710->leave($__internal_b7d30c3c7b277dd26d75a50f905e205f53037ddf6e77bdf080347f27fe035710_prof);

        
        $__internal_14f43d82d0f725f02141ba1da9d034cc093ba56b08b11a54121431ada7f9bb33->leave($__internal_14f43d82d0f725f02141ba1da9d034cc093ba56b08b11a54121431ada7f9bb33_prof);

    }

    // line 53
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_cd5f10bfa12eaf0db04b9a73c88ba958a3feed6157c4c3ef38f7931e54c695bf = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_cd5f10bfa12eaf0db04b9a73c88ba958a3feed6157c4c3ef38f7931e54c695bf->enter($__internal_cd5f10bfa12eaf0db04b9a73c88ba958a3feed6157c4c3ef38f7931e54c695bf_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        $__internal_7498ab9010acbb09bb13f10d92c331bc9d013bd921af4a7f779173a39955b0bc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7498ab9010acbb09bb13f10d92c331bc9d013bd921af4a7f779173a39955b0bc->enter($__internal_7498ab9010acbb09bb13f10d92c331bc9d013bd921af4a7f779173a39955b0bc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

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
        
        $__internal_7498ab9010acbb09bb13f10d92c331bc9d013bd921af4a7f779173a39955b0bc->leave($__internal_7498ab9010acbb09bb13f10d92c331bc9d013bd921af4a7f779173a39955b0bc_prof);

        
        $__internal_cd5f10bfa12eaf0db04b9a73c88ba958a3feed6157c4c3ef38f7931e54c695bf->leave($__internal_cd5f10bfa12eaf0db04b9a73c88ba958a3feed6157c4c3ef38f7931e54c695bf_prof);

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
            <p>&copy; 2018 - Software University Foundation</p>
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
