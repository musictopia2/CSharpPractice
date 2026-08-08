# C# Practice

This repository contains my ongoing C# practice exercises and small programming challenges.

The goal is not simply to complete a course or collect finished solutions. I am using this repository for deliberate hands-on practice in Visual Studio, with automated tests used whenever they are appropriate.

## Goals

This repository is intended to:

* provide regular hands-on C# practice;
* reinforce each concept with multiple exercises rather than a single example;
* use automated tests to verify requirements;
* practice debugging when an implementation does not initially pass;
* gradually progress from simple exercises to more realistic requirements;
* provide small, focused examples that I can use as a reference later;
* document my progress as I continue learning and practicing C#.

## Structure

The repository is organized into numbered sections based on the progression of C# concepts being studied.

For example:

```text
01_HelloWorld
02_BasicTypes
03_Operators
04_ControlFlow
05_Loops
...
```

Each section normally contains an implementation project and a corresponding test project.

Topics within a section are organized using folders and namespaces.

## Exercise Approach

Each topic normally contains at least five exercises.

The exercises are designed to progress from basic understanding toward independent application:

1. an introductory exercise focused directly on the concept;
2. a reinforcement exercise using the concept differently;
3. a variation involving different conditions or edge cases;
4. an exercise combining the concept with previously learned material;
5. a small client-style requirement requiring more independent implementation decisions.

Additional exercises may be added when a topic needs more practice.

The goal is not repetition for its own sake. Each exercise should introduce a useful variation, reinforce an important detail, expose an edge case, or require a different application of existing knowledge.

## Testing

Automated tests are an important part of the practice process.

When an exercise can reasonably be tested, I am not considering it complete until its applicable tests pass.

Tests may verify:

* expected behavior;
* edge cases;
* exact values;
* exact text output;
* capitalization and punctuation;
* required types or API contracts.

Not every C# concept has meaningful runtime behavior to test. Exercises involving things such as comments may therefore not have automated tests.

## Development Environment

Exercises are completed using Visual Studio and normal .NET development tooling.

This includes IntelliSense, compiler diagnostics, debugging, and the Visual Studio test tooling.

The purpose is to practice C# in a normal development environment rather than artificially avoiding tools that would ordinarily be available during development.

## Learning Material

The initial topic progression is inspired by material I am studying, but the exercises, tests, implementations, and documentation contained in this repository are my own practice material.

The repository is intended to grow beyond any single course or learning resource.

Over time, additional topics and more advanced exercises will be added as appropriate.

## Long-Term Purpose

This repository is also intended to become a personal C# reference.

Rather than having to search through a large application to remember how I previously used a particular C# feature, I want to have small, focused, working examples that are easy to find and understand.

As my experience grows, I expect the exercises to progress from fundamental language features toward debugging, refactoring, testing, design decisions, and increasingly realistic programming requirements.
