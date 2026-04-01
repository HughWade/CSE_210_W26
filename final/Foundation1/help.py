for x in range(4):
    for i in range(4):
        print(f"video{x+1}.comments.Add(comment{x+1}{i+1});")

for i in range(4):
    print(f"videoList.Add(video{i+1})")
    


"""video1.comments.Add(comment11);"""