const Calculator = require('./../models/Calculator');

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost: (req, res) => {
        let params = req.body.calculator;

        let leftOperand = params.leftOperand;
        let operator = params.operator;
        let rightOperand = params.rightOperand;

        const regex = /^[0-9]+$/;
        if (leftOperand.match(regex) && rightOperand.match(regex)) {
            let calculator = new Calculator(Number(leftOperand), operator, Number(rightOperand));
            let result = calculator.calculate();
            res.render('home/index', { 'calculator': calculator, 'result': result });
        } else {
            res.render('home/index', {error:'Please enter valid numbers!'});
        }

    }
};