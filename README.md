# Random Quote, Joke, and Fact Generator

A Windows Forms VB.NET application that allows users to generate:

* **Motivational Quotes**
* **Random Jokes**
* **Random Facts**

All content is fetched in real-time from free public APIs.

This project demonstrates my skills in **VB.NET**, **Windows Forms**, **API integration**, **asynchronous programming**, and **UI design**.

---

## Features

* **Homepage UI** with buttons to select Quotes, Jokes, or Facts.
* **Async API requests** to keep the app responsive.
* **Error handling** for failed or unavailable API requests.
* **Clean, user-friendly interface**.

---

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/yourusername/RandomQuoteGenerator.git
```

2. Open the solution file `RandomQuoteGenerator.sln` in Visual Studio.
3. Restore NuGet packages if needed (Visual Studio will handle this automatically).
4. Build and run the project.

---

## APIs Used

* **Motivational Quotes**: [ZenQuotes](https://zenquotes.io/)
* **Jokes**: [Official Joke API](https://official-joke-api.appspot.com/)
* **Facts**: [The Fact Space API](https://thefact.space/)

> All APIs are free and require no authentication.

---

## Skills Demonstrated

* Windows Forms development with VB.NET
* Object-Oriented Programming (OOP)
* Asynchronous HTTP requests (`HttpClient`)
* JSON parsing with **Newtonsoft.Json**
* Basic UI/UX design for desktop applications
* Handling API errors and edge cases

---

## Main Code Files

The project is organized into the following main source files:

- [`frmHome.vb`](RandomQuoteGenerator/Form1.vb) – The homepage form that lets users select Quotes, Jokes, or Facts.
- [`frmMotivational.vb`](RandomQuoteGenerator/Motivational.vb) – Handles fetching and displaying motivational quotes.
- [`frmJokes.vb`](RandomQuoteGenerator/frmJokes.vb) – Handles fetching and displaying random jokes.
- [`frmFacts.vb`](RandomQuoteGenerator/frmFacts.vb) – Handles fetching and displaying random facts.


## Notes

* This project is designed to be **readable and professional** for potential employers.
* No login or authentication is required to use the app.
* All API requests are handled asynchronously for smooth performance.
