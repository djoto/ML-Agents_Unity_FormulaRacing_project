SETUP ENVIRONMENT:

Step 1: Download Unity and Unity Hub - https://unity3d.com/get-unity/download


Step 2: Setup ML-Agents (https://github.com/Unity-Technologies/ml-agents}{ML-Agents)

    Step 2.1: Download Python (used version 3.7.9): https://www.python.org/downloads/
    
    Step 2.2: Check Python version by typing 'python --version' in console
    
    Step 2.3: Create Unity project
    
    Step 2.4: Type 'cd <path-to-your-unity-project>' in console
    
    Step 2.5: Create Python virtual environment by typing 'python -m venv venv'
    
    Step 2.6: Activate virtual envoronment by typing
              'venv/Scripts/activate' on Windows or 'source venv/bin/activate' on Linux
    
    Step 2.7: Upgrade pip installer by typing 'python -m pip install –-upgrade pip'
    
    Step 2.8: Install PyTorch library for Machine Learning by typing 
              'pip install torch==1.7.0 -f https://download.pytorch.org/whl/torch_stable.html'
              
    Step 2.9: Install ML-Agents by typing 'pip install mlagents'
    
    Step 2.10: Chech if ML-Agents instaled successfully by typing 'mlagents-learn --help'

    
Step 3: Open Unity project in Unity editor and install ML-Agents for that project:

    Step 3.1: Go to 'Window > Package Manager'
    
    Step 3.2: Select 'Packages: In Projects' and select 'Unity Registry' option
    
    Step 3.3: Find and choose 'ML Agents' from list and click 'Install'
    

