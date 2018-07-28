<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_99b2a225cb70aa4a8d48984f92fa0c34ec0fea32a96ff1e63d94ed7465a2ded8 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_e8f25bcdd91093ac8c86c15c31a51555a0052ba976f27842f3e2097fff95e335 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e8f25bcdd91093ac8c86c15c31a51555a0052ba976f27842f3e2097fff95e335->enter($__internal_e8f25bcdd91093ac8c86c15c31a51555a0052ba976f27842f3e2097fff95e335_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_00bffe1d96f5feb27ae1441202d024773ebc20ed31f74292981fb386d7ddba09 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_00bffe1d96f5feb27ae1441202d024773ebc20ed31f74292981fb386d7ddba09->enter($__internal_00bffe1d96f5feb27ae1441202d024773ebc20ed31f74292981fb386d7ddba09_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_e8f25bcdd91093ac8c86c15c31a51555a0052ba976f27842f3e2097fff95e335->leave($__internal_e8f25bcdd91093ac8c86c15c31a51555a0052ba976f27842f3e2097fff95e335_prof);

        
        $__internal_00bffe1d96f5feb27ae1441202d024773ebc20ed31f74292981fb386d7ddba09->leave($__internal_00bffe1d96f5feb27ae1441202d024773ebc20ed31f74292981fb386d7ddba09_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_bd85d823f2746c7bac29b7047e99225af9897e22a0e1ced13f3a9ad046d2543f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_bd85d823f2746c7bac29b7047e99225af9897e22a0e1ced13f3a9ad046d2543f->enter($__internal_bd85d823f2746c7bac29b7047e99225af9897e22a0e1ced13f3a9ad046d2543f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_3c6e95e95cfed72bef46379998a70980843278d9647eb0bda5f2d0b476709f24 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3c6e95e95cfed72bef46379998a70980843278d9647eb0bda5f2d0b476709f24->enter($__internal_3c6e95e95cfed72bef46379998a70980843278d9647eb0bda5f2d0b476709f24_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_3c6e95e95cfed72bef46379998a70980843278d9647eb0bda5f2d0b476709f24->leave($__internal_3c6e95e95cfed72bef46379998a70980843278d9647eb0bda5f2d0b476709f24_prof);

        
        $__internal_bd85d823f2746c7bac29b7047e99225af9897e22a0e1ced13f3a9ad046d2543f->leave($__internal_bd85d823f2746c7bac29b7047e99225af9897e22a0e1ced13f3a9ad046d2543f_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_b8b78c2d9868b354f65504b72ddca16d63ce90a573b290e2e83b566199391a63 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b8b78c2d9868b354f65504b72ddca16d63ce90a573b290e2e83b566199391a63->enter($__internal_b8b78c2d9868b354f65504b72ddca16d63ce90a573b290e2e83b566199391a63_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_f5db58298801f2d1c68147990bf6924a00856386b04021e86e7091946dc9ac64 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f5db58298801f2d1c68147990bf6924a00856386b04021e86e7091946dc9ac64->enter($__internal_f5db58298801f2d1c68147990bf6924a00856386b04021e86e7091946dc9ac64_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_f5db58298801f2d1c68147990bf6924a00856386b04021e86e7091946dc9ac64->leave($__internal_f5db58298801f2d1c68147990bf6924a00856386b04021e86e7091946dc9ac64_prof);

        
        $__internal_b8b78c2d9868b354f65504b72ddca16d63ce90a573b290e2e83b566199391a63->leave($__internal_b8b78c2d9868b354f65504b72ddca16d63ce90a573b290e2e83b566199391a63_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_fd3a322b360c93373671fb50e3cfb1dd356b044aa7fe6ecca569697cae036230 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_fd3a322b360c93373671fb50e3cfb1dd356b044aa7fe6ecca569697cae036230->enter($__internal_fd3a322b360c93373671fb50e3cfb1dd356b044aa7fe6ecca569697cae036230_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_64f12bc581e0951aeec2539a92bbb439ad03e1a367f79a2ff312d4cec7940085 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_64f12bc581e0951aeec2539a92bbb439ad03e1a367f79a2ff312d4cec7940085->enter($__internal_64f12bc581e0951aeec2539a92bbb439ad03e1a367f79a2ff312d4cec7940085_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_64f12bc581e0951aeec2539a92bbb439ad03e1a367f79a2ff312d4cec7940085->leave($__internal_64f12bc581e0951aeec2539a92bbb439ad03e1a367f79a2ff312d4cec7940085_prof);

        
        $__internal_fd3a322b360c93373671fb50e3cfb1dd356b044aa7fe6ecca569697cae036230->leave($__internal_fd3a322b360c93373671fb50e3cfb1dd356b044aa7fe6ecca569697cae036230_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
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

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "D:\\Homework\\Softuni\\Tech-Module-May-2018\\Software-Technologies-July-2018\\Calculator-PHP\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
