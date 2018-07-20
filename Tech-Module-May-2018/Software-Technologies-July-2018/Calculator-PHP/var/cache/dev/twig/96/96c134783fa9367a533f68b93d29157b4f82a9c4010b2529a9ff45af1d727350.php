<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_d496044effa4cc39ce51801babe801f9942ccc5fec27a124c696ada197249fa7 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_7e4017c2fd656e5c6a801bb3e480f9dd93e469d7290054be566c54c2ac54e61d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7e4017c2fd656e5c6a801bb3e480f9dd93e469d7290054be566c54c2ac54e61d->enter($__internal_7e4017c2fd656e5c6a801bb3e480f9dd93e469d7290054be566c54c2ac54e61d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_06e10b797b45c31deca0138bff9bd57d2591972361b67ef8d2103ef1a3854f92 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_06e10b797b45c31deca0138bff9bd57d2591972361b67ef8d2103ef1a3854f92->enter($__internal_06e10b797b45c31deca0138bff9bd57d2591972361b67ef8d2103ef1a3854f92_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_7e4017c2fd656e5c6a801bb3e480f9dd93e469d7290054be566c54c2ac54e61d->leave($__internal_7e4017c2fd656e5c6a801bb3e480f9dd93e469d7290054be566c54c2ac54e61d_prof);

        
        $__internal_06e10b797b45c31deca0138bff9bd57d2591972361b67ef8d2103ef1a3854f92->leave($__internal_06e10b797b45c31deca0138bff9bd57d2591972361b67ef8d2103ef1a3854f92_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_1074c9cab05812147f9f4a115ca607178168f53ccb4317f58d041696a565f84a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1074c9cab05812147f9f4a115ca607178168f53ccb4317f58d041696a565f84a->enter($__internal_1074c9cab05812147f9f4a115ca607178168f53ccb4317f58d041696a565f84a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_30a086c3ca296f5d2fe21393a7acdcb7fd4f9999326d6135f42b422fda6968a2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_30a086c3ca296f5d2fe21393a7acdcb7fd4f9999326d6135f42b422fda6968a2->enter($__internal_30a086c3ca296f5d2fe21393a7acdcb7fd4f9999326d6135f42b422fda6968a2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_30a086c3ca296f5d2fe21393a7acdcb7fd4f9999326d6135f42b422fda6968a2->leave($__internal_30a086c3ca296f5d2fe21393a7acdcb7fd4f9999326d6135f42b422fda6968a2_prof);

        
        $__internal_1074c9cab05812147f9f4a115ca607178168f53ccb4317f58d041696a565f84a->leave($__internal_1074c9cab05812147f9f4a115ca607178168f53ccb4317f58d041696a565f84a_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_5634f3df615f0667b293be81d89b91b914a8a7bfc6a9b99b69b4a48912ce3e3d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_5634f3df615f0667b293be81d89b91b914a8a7bfc6a9b99b69b4a48912ce3e3d->enter($__internal_5634f3df615f0667b293be81d89b91b914a8a7bfc6a9b99b69b4a48912ce3e3d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_c2798d9ce97bf71fe26db2bb19e80c19702b6c87819af676d3afd6529c168045 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c2798d9ce97bf71fe26db2bb19e80c19702b6c87819af676d3afd6529c168045->enter($__internal_c2798d9ce97bf71fe26db2bb19e80c19702b6c87819af676d3afd6529c168045_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_c2798d9ce97bf71fe26db2bb19e80c19702b6c87819af676d3afd6529c168045->leave($__internal_c2798d9ce97bf71fe26db2bb19e80c19702b6c87819af676d3afd6529c168045_prof);

        
        $__internal_5634f3df615f0667b293be81d89b91b914a8a7bfc6a9b99b69b4a48912ce3e3d->leave($__internal_5634f3df615f0667b293be81d89b91b914a8a7bfc6a9b99b69b4a48912ce3e3d_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_8ed44a480628d54377d9b871f83473a812c18a19bf37d6dd4a6b7416990efce3 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8ed44a480628d54377d9b871f83473a812c18a19bf37d6dd4a6b7416990efce3->enter($__internal_8ed44a480628d54377d9b871f83473a812c18a19bf37d6dd4a6b7416990efce3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_a0a068e533d69aee823344f8a4a3981b8e07465464e130922ec3c910129fd748 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a0a068e533d69aee823344f8a4a3981b8e07465464e130922ec3c910129fd748->enter($__internal_a0a068e533d69aee823344f8a4a3981b8e07465464e130922ec3c910129fd748_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_a0a068e533d69aee823344f8a4a3981b8e07465464e130922ec3c910129fd748->leave($__internal_a0a068e533d69aee823344f8a4a3981b8e07465464e130922ec3c910129fd748_prof);

        
        $__internal_8ed44a480628d54377d9b871f83473a812c18a19bf37d6dd4a6b7416990efce3->leave($__internal_8ed44a480628d54377d9b871f83473a812c18a19bf37d6dd4a6b7416990efce3_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "D:\\Homework\\Softuni\\Tech-Module-May-2018\\Software-Technologies-July-2018\\Calculator-PHP\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
