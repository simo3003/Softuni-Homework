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
        $__internal_440d884dbe34c1ff703e4f883c62999facb673f2161aabdbaa937cb5c5a6813c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_440d884dbe34c1ff703e4f883c62999facb673f2161aabdbaa937cb5c5a6813c->enter($__internal_440d884dbe34c1ff703e4f883c62999facb673f2161aabdbaa937cb5c5a6813c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_74b650866bb8a8a406451722cf11bbf638b36c98fd0185dcc94c9929a230e077 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_74b650866bb8a8a406451722cf11bbf638b36c98fd0185dcc94c9929a230e077->enter($__internal_74b650866bb8a8a406451722cf11bbf638b36c98fd0185dcc94c9929a230e077_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_440d884dbe34c1ff703e4f883c62999facb673f2161aabdbaa937cb5c5a6813c->leave($__internal_440d884dbe34c1ff703e4f883c62999facb673f2161aabdbaa937cb5c5a6813c_prof);

        
        $__internal_74b650866bb8a8a406451722cf11bbf638b36c98fd0185dcc94c9929a230e077->leave($__internal_74b650866bb8a8a406451722cf11bbf638b36c98fd0185dcc94c9929a230e077_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_6edafbfa0f8b0a1641a646aa161554266d55afd0e640bc95f027f01bb94620ac = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6edafbfa0f8b0a1641a646aa161554266d55afd0e640bc95f027f01bb94620ac->enter($__internal_6edafbfa0f8b0a1641a646aa161554266d55afd0e640bc95f027f01bb94620ac_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_989e7013a59630dde15b46abba93ec0bbb409d964c5b44a74fe035f677aea9e7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_989e7013a59630dde15b46abba93ec0bbb409d964c5b44a74fe035f677aea9e7->enter($__internal_989e7013a59630dde15b46abba93ec0bbb409d964c5b44a74fe035f677aea9e7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_989e7013a59630dde15b46abba93ec0bbb409d964c5b44a74fe035f677aea9e7->leave($__internal_989e7013a59630dde15b46abba93ec0bbb409d964c5b44a74fe035f677aea9e7_prof);

        
        $__internal_6edafbfa0f8b0a1641a646aa161554266d55afd0e640bc95f027f01bb94620ac->leave($__internal_6edafbfa0f8b0a1641a646aa161554266d55afd0e640bc95f027f01bb94620ac_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_51ceeee82aea9fa8bad1502d35df5d01baa9a15360d4a894f5b154c5835d9261 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_51ceeee82aea9fa8bad1502d35df5d01baa9a15360d4a894f5b154c5835d9261->enter($__internal_51ceeee82aea9fa8bad1502d35df5d01baa9a15360d4a894f5b154c5835d9261_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_ef047cb9c7c9ab9f8ee729dea902339ec2e452bf26f5698af946f191fd8e22ce = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ef047cb9c7c9ab9f8ee729dea902339ec2e452bf26f5698af946f191fd8e22ce->enter($__internal_ef047cb9c7c9ab9f8ee729dea902339ec2e452bf26f5698af946f191fd8e22ce_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_ef047cb9c7c9ab9f8ee729dea902339ec2e452bf26f5698af946f191fd8e22ce->leave($__internal_ef047cb9c7c9ab9f8ee729dea902339ec2e452bf26f5698af946f191fd8e22ce_prof);

        
        $__internal_51ceeee82aea9fa8bad1502d35df5d01baa9a15360d4a894f5b154c5835d9261->leave($__internal_51ceeee82aea9fa8bad1502d35df5d01baa9a15360d4a894f5b154c5835d9261_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_830273a2d72093fcb9a75ef815e97afca7bec3c6b7df7d5ae871d054f2e1bb72 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_830273a2d72093fcb9a75ef815e97afca7bec3c6b7df7d5ae871d054f2e1bb72->enter($__internal_830273a2d72093fcb9a75ef815e97afca7bec3c6b7df7d5ae871d054f2e1bb72_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_cb706e38e0a9b7b59baa97ff00a918cd835ebdcf145570d41bd72e8cb0e2c3f2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cb706e38e0a9b7b59baa97ff00a918cd835ebdcf145570d41bd72e8cb0e2c3f2->enter($__internal_cb706e38e0a9b7b59baa97ff00a918cd835ebdcf145570d41bd72e8cb0e2c3f2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_cb706e38e0a9b7b59baa97ff00a918cd835ebdcf145570d41bd72e8cb0e2c3f2->leave($__internal_cb706e38e0a9b7b59baa97ff00a918cd835ebdcf145570d41bd72e8cb0e2c3f2_prof);

        
        $__internal_830273a2d72093fcb9a75ef815e97afca7bec3c6b7df7d5ae871d054f2e1bb72->leave($__internal_830273a2d72093fcb9a75ef815e97afca7bec3c6b7df7d5ae871d054f2e1bb72_prof);

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
