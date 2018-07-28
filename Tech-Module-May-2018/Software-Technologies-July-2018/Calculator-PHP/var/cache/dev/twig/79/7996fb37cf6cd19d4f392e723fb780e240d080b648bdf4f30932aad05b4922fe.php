<?php

/* @WebProfiler/Collector/ajax.html.twig */
class __TwigTemplate_b85f29821be27aa8b1bc98519436461388017d9d368062ef3d8575c22bceff2f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/ajax.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_f7e69ff5ff3a878e23c22db957e7811bf1ff0ef068e9cde840ce4cf714e155e3 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f7e69ff5ff3a878e23c22db957e7811bf1ff0ef068e9cde840ce4cf714e155e3->enter($__internal_f7e69ff5ff3a878e23c22db957e7811bf1ff0ef068e9cde840ce4cf714e155e3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $__internal_b574d09eb1ae77df93bfdf95601521c4aebdba2cee3d502cbe0c357645c02be4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b574d09eb1ae77df93bfdf95601521c4aebdba2cee3d502cbe0c357645c02be4->enter($__internal_b574d09eb1ae77df93bfdf95601521c4aebdba2cee3d502cbe0c357645c02be4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_f7e69ff5ff3a878e23c22db957e7811bf1ff0ef068e9cde840ce4cf714e155e3->leave($__internal_f7e69ff5ff3a878e23c22db957e7811bf1ff0ef068e9cde840ce4cf714e155e3_prof);

        
        $__internal_b574d09eb1ae77df93bfdf95601521c4aebdba2cee3d502cbe0c357645c02be4->leave($__internal_b574d09eb1ae77df93bfdf95601521c4aebdba2cee3d502cbe0c357645c02be4_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_fc62678c78dbbb4b3a3fea2189deca9bbe52cca3aa80fd4b1e74aba430195212 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_fc62678c78dbbb4b3a3fea2189deca9bbe52cca3aa80fd4b1e74aba430195212->enter($__internal_fc62678c78dbbb4b3a3fea2189deca9bbe52cca3aa80fd4b1e74aba430195212_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_1f5570f54bd7b250603d7ed5f54d55cf21e6667c0e2dc45fd442d9a3bb996159 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1f5570f54bd7b250603d7ed5f54d55cf21e6667c0e2dc45fd442d9a3bb996159->enter($__internal_1f5570f54bd7b250603d7ed5f54d55cf21e6667c0e2dc45fd442d9a3bb996159_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        // line 4
        echo "    ";
        ob_start();
        // line 5
        echo "        ";
        echo twig_include($this->env, $context, "@WebProfiler/Icon/ajax.svg");
        echo "
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    ";
        $context["icon"] = ('' === $tmp = ob_get_clean()) ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 8
        echo "
    ";
        // line 9
        $context["text"] = ('' === $tmp = "        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    ") ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 29
        echo "
    ";
        // line 30
        echo twig_include($this->env, $context, "@WebProfiler/Profiler/toolbar_item.html.twig", array("link" => false));
        echo "
";
        
        $__internal_1f5570f54bd7b250603d7ed5f54d55cf21e6667c0e2dc45fd442d9a3bb996159->leave($__internal_1f5570f54bd7b250603d7ed5f54d55cf21e6667c0e2dc45fd442d9a3bb996159_prof);

        
        $__internal_fc62678c78dbbb4b3a3fea2189deca9bbe52cca3aa80fd4b1e74aba430195212->leave($__internal_fc62678c78dbbb4b3a3fea2189deca9bbe52cca3aa80fd4b1e74aba430195212_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/ajax.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  85 => 30,  82 => 29,  62 => 9,  59 => 8,  52 => 5,  49 => 4,  40 => 3,  11 => 1,);
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

{% block toolbar %}
    {% set icon %}
        {{ include('@WebProfiler/Icon/ajax.svg') }}
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    {% endset %}

    {% set text %}
        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    {% endset %}

    {{ include('@WebProfiler/Profiler/toolbar_item.html.twig', { link: false }) }}
{% endblock %}
", "@WebProfiler/Collector/ajax.html.twig", "D:\\Homework\\Softuni\\Tech-Module-May-2018\\Software-Technologies-July-2018\\Calculator-PHP\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\ajax.html.twig");
    }
}
