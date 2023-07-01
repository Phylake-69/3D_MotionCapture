import cv2
from cvzone.PoseModule import PoseDetector  # computer vision detection library

cap = cv2.VideoCapture('Video.mp4')

detector = PoseDetector()
posList = []
while True:
    success, img = cap.read()
    img = cv2.resize(img, (1280, 720))
    img = detector.findPose(img)
    lmList, bboxInfo = detector.findPosition(img)
    # mediapipe(used as findPose) is the simplest way for researches and developers
    # to build world class ML solutions and applications for mobile,edge,cloud and the web

    if bboxInfo:
        lmString = ''
        for lm in lmList:
            lmString += f'{lm[1]},{img.shape[0] - lm[2]},{lm[3]},'

        posList.append(lmString)

    print(len(posList))

    cv2.imshow("Image", img)
    key = cv2.waitKey(1)

    if key == ord('s'):
        with open("AnimationFile.txt", 'w') as f:
            f.writelines(["%s\n" % item for item in posList])  # Loop through all the items and put them in one by one
