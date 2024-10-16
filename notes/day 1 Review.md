# Day 1 Review

Please address your current understanding of the following topics we covered (or began to cover) in class today. Your thoughts about these can and should be revised throughout the training (and your career!) as your understanding grows.

I am *not* looking for super "technical" stuff here. Just your ability to express and convey in your way your understanding of these things.

## 1. Git

We created a git repository on our VMs and added some existing code and committed it. We then used the `gh` cli tool to push that code to Github. 

- Say a few words about why *we* are using source control in this class?
    To keep track of code commits we do in each class.

- Say a few words about how source control is used by teams of developers working on the same code base.
   Developers clone the Git repo into their local machine and then start working on their task. 
   When the task is completed then they will commit their changes and push the code to the Common Git repo

- What is meant when we say a copy of the repository is the "origin"? (That's our copy on github).
    Origin is our main branch that has final project.

- Why do we create commits locally?
   To save all the changes we did in our local machine to the project.

- Why do we push those commits to Github?
    When we push code to GitHub everyone can see our code changes.


### Extra Credit

What were the steps, as detailed as you like, that we took to create our repository and push it to Github.
    create a repository in our classroom directory : `git init` 
    make code changes in your local machine 
    stage code: `git add .`
    commit local changes with a Message : commit `git commit -m "Commit Message"`.
    create a repository under our Github accounts : (`gh repo create`)
    push our commits to that repository : git push origin main

What are some other ways you might do the same thing?
    using UI in our code editor VSCode we can stage, commit and push our chnages to git


## 2. Services

We began a project in Visual Studio to create a service. What is meant by the term "Service" in software development?
    A Service is a thing that does some stuff in our project.

Our service exposes an *interface* that other applications can use to drive our service (make it do stuff). This is an
"Application Programming Interfact". How does an API differ from a "User Interface" (UI)? How are they similiar?
     API helps us to communicts with other appliction useing dsome protocales like Http, 
     where as UI is exposed to user and take input from users with a grephical user interface like keyboard mouse or display 

What are some benefits of exposing a service's interface using the HTTP Protocol?
HTTP is a universal protocal, it is not owned by any single organisation. 
 It helps us to communicate with any machine that is connectd to internet.


We "tested" our API three different ways. 

1. Manually using SwaggerUI
2. Manually using the `.http` file functionality in Visual Studio
3. Automated using an xUnit test project.

Which is the *right* way to do it? Why give preference to automated tests?
    Automated tests are great for porformace and scalablity
    Where as Manul testing is great for catching unexpected bugs that maybe missed by Automated tests


### Extra Credit

Have you used any existing HTTP APIs in other projects?
yes I have used HTTP APIs in my previous projects


Have you created any other HTTP APIs in your own work or studies?
yes I have created HTTP APIs in my previous projects and work.
