import fiftyone
dataset = fiftyone.zoo.load_zoo_dataset(
              "open-images-v7",
              split="test",
              label_types=["detections", "segmentations", "points"],
              classes=["Salad"],
              max_samples=100,
          )

print(dataset)