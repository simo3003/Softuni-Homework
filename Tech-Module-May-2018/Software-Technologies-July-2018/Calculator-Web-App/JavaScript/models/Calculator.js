class Calculator {
    constructor(leftOperand, operator, rightOperand) {
        this.leftOperand = leftOperand;
        this.operator = operator;
        this.rightOperand = rightOperand;
    }

    calculate() {
        switch (this.operator) {
            case '+':
                return this.leftOperand + this.rightOperand;
            case '-':
                return this.leftOperand - this.rightOperand;
            case '*':
                return this.leftOperand * this.rightOperand;
            case '/':
                return this.leftOperand / this.rightOperand;
            case '^':
                return this.leftOperand ** this.rightOperand;
            default:
                break;
        }
    }
}

module.exports = Calculator;

