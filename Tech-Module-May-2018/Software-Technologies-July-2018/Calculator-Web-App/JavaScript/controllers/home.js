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

        let calculator = new Calculator(Number(leftOperand), operator, Number(rightOperand));
        let result = calculator.calculate();
        
        res.render('home/index', {'calculator':calculator, 'result':result});
    }
};