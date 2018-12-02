function solve(name, age, weight, height) {
  const BMI = Math.round(weight / (((height / 100) * height) / 100));
  let status;

  if (BMI < 18.5) {
    status = "underweight";
  } else if (BMI < 25) {
    status = "normal";
  } else if (BMI < 30) {
    status = "overweight";
  } else {
    status = "obese";
  }

  let result = {
    name,
    personalInfo: {
      age,
      weight: Math.round(weight),
      height: Math.round(height)
    },
    BMI,
    status
  };

  if (status == "obese") {
      result.recommendation = "admission required";
  }

  return result;
}
