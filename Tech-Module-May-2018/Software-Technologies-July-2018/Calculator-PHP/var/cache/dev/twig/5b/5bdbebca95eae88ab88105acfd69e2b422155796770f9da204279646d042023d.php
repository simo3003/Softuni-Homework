<?php

/* calculator/index.html.twig */
class __TwigTemplate_b42e924e868d0e0b9f6a10cc5a0a44b7692ae2bf5cece60b210ba163eb491645 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "calculator/index.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_3816f878ed67e5dae76d7e07c683b7f70c90c98f93822708ba019dc635641622 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3816f878ed67e5dae76d7e07c683b7f70c90c98f93822708ba019dc635641622->enter($__internal_3816f878ed67e5dae76d7e07c683b7f70c90c98f93822708ba019dc635641622_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "calculator/index.html.twig"));

        $__internal_1fe5d28598949c5f49469611d05a2b867e7067a299042f24662fa811423db655 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1fe5d28598949c5f49469611d05a2b867e7067a299042f24662fa811423db655->enter($__internal_1fe5d28598949c5f49469611d05a2b867e7067a299042f24662fa811423db655_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "calculator/index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_3816f878ed67e5dae76d7e07c683b7f70c90c98f93822708ba019dc635641622->leave($__internal_3816f878ed67e5dae76d7e07c683b7f70c90c98f93822708ba019dc635641622_prof);

        
        $__internal_1fe5d28598949c5f49469611d05a2b867e7067a299042f24662fa811423db655->leave($__internal_1fe5d28598949c5f49469611d05a2b867e7067a299042f24662fa811423db655_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_48a10f56042a8774fba53eb86442e9d8bf28f85d3dbfdf0ecc474d5730f74f9b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_48a10f56042a8774fba53eb86442e9d8bf28f85d3dbfdf0ecc474d5730f74f9b->enter($__internal_48a10f56042a8774fba53eb86442e9d8bf28f85d3dbfdf0ecc474d5730f74f9b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_e52491d4650648107f06570163d83f5d4b563d4e632cd191d2a35bd098dff518 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e52491d4650648107f06570163d83f5d4b563d4e632cd191d2a35bd098dff518->enter($__internal_e52491d4650648107f06570163d83f5d4b563d4e632cd191d2a35bd098dff518_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div class=\"container body-content span=8 offset=2\">
        <div class=\"well\">
            <form class=\"form-inline\" action=\"";
        // line 6
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" method=\"POST\">
                <fieldset>
                    <div class=\"form-group\">
                        <div class=\"col-sm-1 \">
                            <input type=\"number\" class=\"form-control\" id=\"leftOperand\" placeholder=\"Left Operand\"
                                   name=\"calculator[leftOperand]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, ((($this->getAttribute(($context["calculator"] ?? null), "leftOperand", array(), "any", true, true) &&  !(null === $this->getAttribute(($context["calculator"] ?? null), "leftOperand", array())))) ? ($this->getAttribute(($context["calculator"] ?? null), "leftOperand", array())) : ("")), "html", null, true);
        echo "\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <select class=\"form-control\" name=\"calculator[operator]\">
                                <option value=\"+\" ";
        // line 18
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "+"))) ? ("selected") : (""));
        echo ">+</option>
                                <option value=\"-\" ";
        // line 19
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "-"))) ? ("selected") : (""));
        echo ">-</option>
                                <option value=\"*\" ";
        // line 20
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "*"))) ? ("selected") : (""));
        echo ">*</option>
                                <option value=\"/\" ";
        // line 21
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "/"))) ? ("selected") : (""));
        echo ">/</option>
                                <option value=\"^\" ";
        // line 22
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "^"))) ? ("selected") : (""));
        echo ">^</option>
                            </select>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"number\" class=\"form-control\" id=\"rightOperand\" placeholder=\"Right Operand\"
                                   name=\"calculator[rightOperand]\" value=\"";
        // line 30
        echo twig_escape_filter($this->env, ((($this->getAttribute(($context["calculator"] ?? null), "rightOperand", array(), "any", true, true) &&  !(null === $this->getAttribute(($context["calculator"] ?? null), "rightOperand", array())))) ? ($this->getAttribute(($context["calculator"] ?? null), "rightOperand", array())) : ("")), "html", null, true);
        echo "\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-2 \">
                            <p>=</p>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"result\" placeholder=\"Result\"
                                   name=\"result\" value=\"";
        // line 43
        echo twig_escape_filter($this->env, (($context["result"]) ?? ("")), "html", null, true);
        echo "\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 col-sm-offset-4\">
                            <button type=\"submit\" class=\"btn btn-primary\">Calculate</button>
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
    </div>
";
        
        $__internal_e52491d4650648107f06570163d83f5d4b563d4e632cd191d2a35bd098dff518->leave($__internal_e52491d4650648107f06570163d83f5d4b563d4e632cd191d2a35bd098dff518_prof);

        
        $__internal_48a10f56042a8774fba53eb86442e9d8bf28f85d3dbfdf0ecc474d5730f74f9b->leave($__internal_48a10f56042a8774fba53eb86442e9d8bf28f85d3dbfdf0ecc474d5730f74f9b_prof);

    }

    public function getTemplateName()
    {
        return "calculator/index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  114 => 43,  98 => 30,  87 => 22,  83 => 21,  79 => 20,  75 => 19,  71 => 18,  61 => 11,  53 => 6,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends 'base.html.twig' %}

{% block main %}
    <div class=\"container body-content span=8 offset=2\">
        <div class=\"well\">
            <form class=\"form-inline\" action=\"{{ path('index') }}\" method=\"POST\">
                <fieldset>
                    <div class=\"form-group\">
                        <div class=\"col-sm-1 \">
                            <input type=\"number\" class=\"form-control\" id=\"leftOperand\" placeholder=\"Left Operand\"
                                   name=\"calculator[leftOperand]\" value=\"{{ calculator.leftOperand ?? '' }}\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <select class=\"form-control\" name=\"calculator[operator]\">
                                <option value=\"+\" {{ calculator is defined and calculator.operator == '+' ? 'selected' : '' }}>+</option>
                                <option value=\"-\" {{ calculator is defined and calculator.operator == '-' ? 'selected' : '' }}>-</option>
                                <option value=\"*\" {{ calculator is defined and calculator.operator == '*' ? 'selected' : '' }}>*</option>
                                <option value=\"/\" {{ calculator is defined and calculator.operator == '/' ? 'selected' : '' }}>/</option>
                                <option value=\"^\" {{ calculator is defined and calculator.operator == '^' ? 'selected' : '' }}>^</option>
                            </select>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"number\" class=\"form-control\" id=\"rightOperand\" placeholder=\"Right Operand\"
                                   name=\"calculator[rightOperand]\" value=\"{{ calculator.rightOperand ?? '' }}\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-2 \">
                            <p>=</p>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"result\" placeholder=\"Result\"
                                   name=\"result\" value=\"{{ result ?? '' }}\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 col-sm-offset-4\">
                            <button type=\"submit\" class=\"btn btn-primary\">Calculate</button>
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
    </div>
{% endblock %}
", "calculator/index.html.twig", "D:\\Homework\\Softuni\\Tech-Module-May-2018\\Software-Technologies-July-2018\\Calculator-PHP\\app\\Resources\\views\\calculator\\index.html.twig");
    }
}
