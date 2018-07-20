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
        $__internal_82a17597b09a395836b6c3f9d214a04df64094405fc465447770e7c862d0f1e9 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_82a17597b09a395836b6c3f9d214a04df64094405fc465447770e7c862d0f1e9->enter($__internal_82a17597b09a395836b6c3f9d214a04df64094405fc465447770e7c862d0f1e9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "calculator/index.html.twig"));

        $__internal_ac118d4575a0f8848edc673f3aecf6b17b91e2987199e07a9816b3c2cfec3459 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ac118d4575a0f8848edc673f3aecf6b17b91e2987199e07a9816b3c2cfec3459->enter($__internal_ac118d4575a0f8848edc673f3aecf6b17b91e2987199e07a9816b3c2cfec3459_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "calculator/index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_82a17597b09a395836b6c3f9d214a04df64094405fc465447770e7c862d0f1e9->leave($__internal_82a17597b09a395836b6c3f9d214a04df64094405fc465447770e7c862d0f1e9_prof);

        
        $__internal_ac118d4575a0f8848edc673f3aecf6b17b91e2987199e07a9816b3c2cfec3459->leave($__internal_ac118d4575a0f8848edc673f3aecf6b17b91e2987199e07a9816b3c2cfec3459_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_a0f15975bcb3a255ee5f8f2185d3846d6648470a4632eddaaf28957232122357 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a0f15975bcb3a255ee5f8f2185d3846d6648470a4632eddaaf28957232122357->enter($__internal_a0f15975bcb3a255ee5f8f2185d3846d6648470a4632eddaaf28957232122357_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_3ffdb1452dc1689fe0e1bcbeebf3a2f14b493d6d80e6d124bdff8a930a72486c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3ffdb1452dc1689fe0e1bcbeebf3a2f14b493d6d80e6d124bdff8a930a72486c->enter($__internal_3ffdb1452dc1689fe0e1bcbeebf3a2f14b493d6d80e6d124bdff8a930a72486c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

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
        
        $__internal_3ffdb1452dc1689fe0e1bcbeebf3a2f14b493d6d80e6d124bdff8a930a72486c->leave($__internal_3ffdb1452dc1689fe0e1bcbeebf3a2f14b493d6d80e6d124bdff8a930a72486c_prof);

        
        $__internal_a0f15975bcb3a255ee5f8f2185d3846d6648470a4632eddaaf28957232122357->leave($__internal_a0f15975bcb3a255ee5f8f2185d3846d6648470a4632eddaaf28957232122357_prof);

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
