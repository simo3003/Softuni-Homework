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
        $__internal_aaf7e8331d03adf34c40d979d31f2ea026b07f46887518f2356b154118e75a67 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_aaf7e8331d03adf34c40d979d31f2ea026b07f46887518f2356b154118e75a67->enter($__internal_aaf7e8331d03adf34c40d979d31f2ea026b07f46887518f2356b154118e75a67_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_ed6d292f8d79a421df99cb237677f3ebb7d73d3317ac1fbc6cc4e5842cfe1f20 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ed6d292f8d79a421df99cb237677f3ebb7d73d3317ac1fbc6cc4e5842cfe1f20->enter($__internal_ed6d292f8d79a421df99cb237677f3ebb7d73d3317ac1fbc6cc4e5842cfe1f20_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_aaf7e8331d03adf34c40d979d31f2ea026b07f46887518f2356b154118e75a67->leave($__internal_aaf7e8331d03adf34c40d979d31f2ea026b07f46887518f2356b154118e75a67_prof);

        
        $__internal_ed6d292f8d79a421df99cb237677f3ebb7d73d3317ac1fbc6cc4e5842cfe1f20->leave($__internal_ed6d292f8d79a421df99cb237677f3ebb7d73d3317ac1fbc6cc4e5842cfe1f20_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_7617e21ecce94154645fecc34be613dacafdae70ff22d195e8bfdf77cb4e70d2 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7617e21ecce94154645fecc34be613dacafdae70ff22d195e8bfdf77cb4e70d2->enter($__internal_7617e21ecce94154645fecc34be613dacafdae70ff22d195e8bfdf77cb4e70d2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_2b2dbee75f286b79333308cc297224778d71a534c41c55c2d24d06496c1d50c3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2b2dbee75f286b79333308cc297224778d71a534c41c55c2d24d06496c1d50c3->enter($__internal_2b2dbee75f286b79333308cc297224778d71a534c41c55c2d24d06496c1d50c3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

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
        
        $__internal_2b2dbee75f286b79333308cc297224778d71a534c41c55c2d24d06496c1d50c3->leave($__internal_2b2dbee75f286b79333308cc297224778d71a534c41c55c2d24d06496c1d50c3_prof);

        
        $__internal_7617e21ecce94154645fecc34be613dacafdae70ff22d195e8bfdf77cb4e70d2->leave($__internal_7617e21ecce94154645fecc34be613dacafdae70ff22d195e8bfdf77cb4e70d2_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_31423f31b871a26362af237c67881de72cd715ab528e6d65ae78c5627549ea27 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_31423f31b871a26362af237c67881de72cd715ab528e6d65ae78c5627549ea27->enter($__internal_31423f31b871a26362af237c67881de72cd715ab528e6d65ae78c5627549ea27_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_7b3759b85c1dff64e2eba7037e5a9e08d86bf37a64db0d7808b2db7d70ab01fc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7b3759b85c1dff64e2eba7037e5a9e08d86bf37a64db0d7808b2db7d70ab01fc->enter($__internal_7b3759b85c1dff64e2eba7037e5a9e08d86bf37a64db0d7808b2db7d70ab01fc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

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
        
        $__internal_7b3759b85c1dff64e2eba7037e5a9e08d86bf37a64db0d7808b2db7d70ab01fc->leave($__internal_7b3759b85c1dff64e2eba7037e5a9e08d86bf37a64db0d7808b2db7d70ab01fc_prof);

        
        $__internal_31423f31b871a26362af237c67881de72cd715ab528e6d65ae78c5627549ea27->leave($__internal_31423f31b871a26362af237c67881de72cd715ab528e6d65ae78c5627549ea27_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_242c4c1d13d2fe96f359f6138837e7d6ce6cd896d0fdcc38442259ed7654efb0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_242c4c1d13d2fe96f359f6138837e7d6ce6cd896d0fdcc38442259ed7654efb0->enter($__internal_242c4c1d13d2fe96f359f6138837e7d6ce6cd896d0fdcc38442259ed7654efb0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_532e9a02f220b32f08250498d6af6964a85359f26093146976d075a261f75c53 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_532e9a02f220b32f08250498d6af6964a85359f26093146976d075a261f75c53->enter($__internal_532e9a02f220b32f08250498d6af6964a85359f26093146976d075a261f75c53_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

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
        
        $__internal_532e9a02f220b32f08250498d6af6964a85359f26093146976d075a261f75c53->leave($__internal_532e9a02f220b32f08250498d6af6964a85359f26093146976d075a261f75c53_prof);

        
        $__internal_242c4c1d13d2fe96f359f6138837e7d6ce6cd896d0fdcc38442259ed7654efb0->leave($__internal_242c4c1d13d2fe96f359f6138837e7d6ce6cd896d0fdcc38442259ed7654efb0_prof);

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
