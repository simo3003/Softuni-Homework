package me.fr3fou.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import me.fr3fou.entity.Calculator;

@Controller
public class HomeController {
    @GetMapping("/")
    public String index(Model model) {
        model.addAttribute("operator", "+");
        model.addAttribute("view", "views/calculatorForm");
        return "base-layout";
    }

    @PostMapping("/")
    public String calculate(@RequestParam String leftOperand,
                            @RequestParam String operator,
                            @RequestParam String rightOperand,
                            Model model) {
        double first;
        double second;

        try {
            first = Double.parseDouble(leftOperand);
        } catch (NumberFormatException e) {
            first = 0;
        }

        try {
            second = Double.parseDouble(rightOperand);
        } catch (NumberFormatException e) {
            second = 0;
        }

        Calculator calc = new Calculator(first, operator, second);

        double result = calc.calculate();

        model.addAttribute("leftOperand", leftOperand);
        model.addAttribute("operator", operator);
        model.addAttribute("rightOperand", rightOperand);

        model.addAttribute("result", result);
        model.addAttribute("view", "views/calculatorForm");

        return "base-layout";
    }
}
